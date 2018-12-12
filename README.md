# Protect your password with Steganography
The idea is very simple. You have a password (or any string) and you want to hide it from the prying eyes.

## The Goal
1) You drag and drop ANY file (eg. music.mp3) into the icon of a calculator!
2) You in your clipboard your extra long password that is hard to memorize.

## Steps through the goal
At the Password_Generator.exe :
1) Choose a text you want to hide (maybe your KeePass master password)
2) Choose ANY file (this will encrypt your text)
3) Click Encrypt and choose YES in the prompt
4) Download the Calculator.exe
5) Drag and Drop your file at the Calculator.exe
6) Now you can paste your password! (ctrl+V)

### Stats for nerds
The encryption algorithm is AES in CBC mode. The key file is being hashed with SHA512 and it's Hexadecimal representation is used as the key for the TEXT encryption.<br/>
```
AES(plainText,Hex(SHA512(keyFile)))
```
