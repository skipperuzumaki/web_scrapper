import requests
import shutil
import csv

def Dwnld(loc,url):
    resp = requests.get(url, stream=True)
    local_file = open(loc, 'wb')
    resp.raw.decode_content = True
    shutil.copyfileobj(resp.raw, local_file)
    del resp
i=0
with open('movies.csv', newline='') as csvfile:
    spamreader = csv.reader(csvfile, delimiter=' ', quotechar='|')
    for row in spamreader:
        Dwnld('.\movies\\'+str(i),row[2])
        i+=1
i=0
with open('tv.csv', newline='') as csvfile:
    spamreader = csv.reader(csvfile, delimiter=' ', quotechar='|')
    for row in spamreader:
        Dwnld('.\\tovies\\'+str(i),row[2])
        i+=1
