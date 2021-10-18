#include <iostream>

#include <string.h>
#include <unistd.h>
#include <stdlib.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <stdio.h>
#include <ctype.h>

using namespace std;

int main(int argc, char *argv[]) {
	
	int sock_conn, sock_listen, ret;
	struct sockaddr_in serv_adr;
	char peticion[512];
	char respuesta[512];
	// INICIALITZACIONS
	// Obrim el socket
	if ((sock_listen = socket(AF_INET, SOCK_STREAM, 0)) < 0)
		printf("Error creant socket");
	// Fem el bind al port
	
	
	memset(&serv_adr, 0, sizeof(serv_adr));// inicialitza a zero serv_addr
	serv_adr.sin_family = AF_INET;
	
	// asocia el socket a cualquiera de las IP de la m?quina. 
	//htonl formatea el numero que recibe al formato necesario
	serv_adr.sin_addr.s_addr = htonl(INADDR_ANY);
	// escucharemos en el port 9050
	serv_adr.sin_port = htons(9060);
	if (bind(sock_listen, (struct sockaddr *) &serv_adr, sizeof(serv_adr)) < 0)
		printf ("Error al bind");
	//La cola de peticiones pendientes no podr? ser superior a 4
	if (listen(sock_listen, 2) < 0)
		printf("Error en el Listen");
	
	//nt i;
	// Atenderemos solo 5 peticione
	for(;;){
		printf ("Escuchando\n");
		
		sock_conn = accept(sock_listen, NULL, NULL);
		printf ("He recibido conexi?n\n");
		//sock_conn es el socket que usaremos para este cliente
		
		//Bucle de atención al cliente
		int terminar = 0;
		while (terminar == 0)
		{		
			// Ahora recibimos su nombre, que dejamos en buff
			ret=read(sock_conn,peticion, sizeof(peticion));
			printf ("Recibido\n");
			
			// Tenemos que a?adirle la marca de fin de string 
			// para que no escriba lo que hay despues en el buffer
			peticion[ret]='\0';
			
			//Escribimos el nombre en la consola
			printf ("Se ha conectado: %s\n",peticion);
			
			char *p = strtok( peticion, "/");
			int codigo =  atoi (p);
			if (codigo==0)
				terminar=1;
			else 
			{
			p = strtok( NULL, "/");
			char nombre[20];
			strcpy (nombre, p);
			printf ("Codigo: %d, Nombre: %s\n", codigo, nombre);
			if (codigo ==1) {
				//piden la longitd del nombre<
				int n;
				n = strlen(nombre);
				sprintf (respuesta,"%d \n",n);
			}
			else if (codigo==2)
					// quieren saber si el nombre es bonito
					if((nombre[0]=='M') || (nombre[0]=='S'))
						strcpy (respuesta,"SI");
					else
						strcpy (respuesta,"NO");
				else if (codigo ==3)
					//El codigo ha de ser 3 = decir si es altx
					{
						p = strtok(NULL,"");
						float altura = atof(p);
						if (altura > 1.7)
							sprintf(respuesta, "%s; eres altx", nombre);
						else
							sprintf (respuesta, "%s: eres bajx", nombre);
					}
				else if (codigo==4){
				//Codigo 4: determinar si es un palíndromo: lol
					int n;
					n = strlen(nombre);
					int c = 0;
					for (int i = 0; i<n; i++){
						if (nombre[i]==nombre[n-i-1])
							c++;
					}
					if (c==n)
						sprintf(respuesta, "%s es un palindromo", nombre);
					else
						sprintf(respuesta, "%s NO es un palindrome", nombre);
					
				}else{
					int n;
					n = strlen(nombre);
					char may[20];
					
					for(int i=0; i<n; i++)
						may[i]= toupper(nombre[i]);
					
					
					sprintf(respuesta, "Tu nombre es: %s\n", may);
				}
						 
				printf ("Respuesta %s\n", respuesta);
				// Y lo enviamos
				write (sock_conn,respuesta, strlen(respuesta));
			}
		}
			// Se acabo el servicio para este cliente
			close(sock_conn); 
		
	}
		
	return 0;
	
}
