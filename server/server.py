import socket
import sys

s = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
port = 3125
ip = '172.24.1.199'
s.bind((ip, port))
print('Socket binded to port 3125')
s.listen(3)
print('socket is listening')

while True:
    c, addr = s.accept()
    print('Got connection from ', addr)
    data = c.recv(1024).decode()
    print(data)
    c.close()
