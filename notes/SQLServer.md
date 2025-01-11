# Connect to SQL server
- Create profile to be used when wanting to connect to SQL server. (ex: BRO)
- Run sihot.exe -@BRO (normal sihot db can be used here)
- Add the settings saved in [SQLdatabaseRegistry](./SQLdatabaseRegistry.png)
    - 6682 password is sihot
- Run reorg.exe -updatesql -@BRO
    -  This will add the db settings to windows registry under BRO:...
- Install \\terminator\temp(F)\sqlncli_2012.msi if neededa (Provider cannot be found. It may not be properly installed. (*) (errorNr:-2146824582))
- DO NOT SERIALIZE
    - Impersonate serial ([ImpersonateSerial](./ImpersonateSerial.md))
