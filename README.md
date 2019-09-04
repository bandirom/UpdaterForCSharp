### Updater For C# programs

If you need to update program (windows form for example) which using many users and located on virtual or network disk

    Program Name  
    ├── Updater.exe (Can be renamed to Program Name)
    └── Application Files (PathToView string)
    ├── Program Name_0.0.0.1
    │   ├── Program Name.exe
    │   └── Other components
    ├── Program Name_0.0.0.5 
    │   ├── Program Name.exe
    │   └── Other components
    └── Other versions
    
# The Updater will choose the newest version and open it 

### When all users open new version via updater, you can easy delete old versions 

