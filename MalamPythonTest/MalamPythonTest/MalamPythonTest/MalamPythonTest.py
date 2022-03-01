


import json
import sys



try:
    f = open (sys.argv[1], "r")
    json.load(f)
    print("ok")
except ValueError as err:
     print("Given JSON string is not Valid",err)
except FileNotFoundError:
     print("Given File is not Found")
except BaseException as err:
    print(f"Unexpected {err=}, {type(err)=}")
    

