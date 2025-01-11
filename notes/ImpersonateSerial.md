# Domain
Create new domain to use the db and impersonateSerial
- Create new profile with the following name convention domain_[DOMAIN] (p.e. domain_MEIN) 
    - Change the db and any other require profile changes
        ```
        [db]
        path=\\s-storage-02\SMB_DATABASES_STORAGE02\MEININGER\14072023
        name=meininger_prod
        ```
- Set impersonateSerial for this version and profile
    - Create new String value in the windows registry for the required version (p.e. HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\GUB Software-Entwicklung\SIHOT Win\v1100.03.01)
        ```json
        {
            name: "__impersonateSerial__@[DOMAIN]", // p.e. __impersonateSerial__@MEIN
            value: "[serialValue]" // p.e. 9f1a*c7TbGwi3pXBbDtnrC:fAh9pXzKypCpe8wsAvVvq9U4GunxDLGIAJvzjyGTIy
        }
        ```
- Set sihot apps to use the domain se configured:
    - Crossbow
        ```
        "MEIN" 15000 CBS_CMD ...
        ```
    - Other apps
        ```
        reorg -c -u * -@MEIN
        sntserv -Si -@MEIN
        sihot -l -@MEIN
        ```
# Descriptions (by Oliver Schlimmermann)
82a627e3e680c31
 
4237*V8R73k6ZTwk0Qd:vYw9KXk9bTA4HpNJcApCAy0Tqwn46Ayvc4IuGztFi2yCAlhO5c
 
The strings above are used in the serial exe to generate the impersonateserial. Open serial.exe and put the key from YOUR database in the first field and the short one I gave you in the second field of serial.exe. 
The longest one in the third field. Ensure there is no impersonateserial entry in windows registry available when doing this.
https://wiki.sihot.com/wiki/doku.php?id=sihotap:mantra_group:citypms:impersonateserial&s[]=impersonateserial
