import os
 
def get_files(dir):
    files = []
    if not os.path.isdir(dir):        
        return files
    for item in os.listdir(dir):
        itemPath = os.path.join(dir, item)
        if not os.path.isdir(itemPath):
            files.append(itemPath)
        elif os.path.isdir(itemPath):
            files.extend(get_files(itemPath))
    return files

# Get the list of all files and directories
path = "G:\\My Drive\\tmp"
dir_list = os.listdir(path) 

res = []
for item in dir_list:
    itemPath = os.path.join(path, item)
    res.extend(get_files(itemPath))

for itemPath in res:
    os.remove(itemPath)

#print(os.linesep.join(map(str,res)))

