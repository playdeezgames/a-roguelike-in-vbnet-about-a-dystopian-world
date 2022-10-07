dotnet publish ./src/Dystopia/Dystopia.vbproj -o ./pub-linux -c Release --sc -r linux-x64
dotnet publish ./src/Dystopia/Dystopia.vbproj -o ./pub-windows -c Release --sc -r win-x64
butler push pub-windows thegrumpygamedev/a-roguelike-in-vbnet-about-a-dystopian-world:windows
butler push pub-linux thegrumpygamedev/a-roguelike-in-vbnet-about-a-dystopian-world:linux
git add -A
git commit -m "shipped it!"