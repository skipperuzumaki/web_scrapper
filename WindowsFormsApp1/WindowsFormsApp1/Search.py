from urllib.request import urlopen
from bs4 import BeautifulSoup as soup
import csv

class Search:
    def __init__(self,search):
        self.generateURL(search)
        self.Data()
        self.parse()
    def generateURL(self,string):
        string = string.replace(' ','%20')
        urls = []
        st = 'https://www.themoviedb.org/search/'+'movie?query='+string+'&language=en'
        urls.append(st)
        st = 'https://www.themoviedb.org/search/'+'tv?query='+string+'&language=en'
        urls.append(st)
        self.url = urls
    def Data(self):
        client = urlopen(self.url[0])
        html_movie = client.read()
        client.close()
        client = urlopen(self.url[1])
        html_tv = client.read()
        client.close()
        self.movie_soup = soup(html_movie,'html.parser')
        self.tv_soup = soup(html_tv,'html.parser')
    def parse(self):
        self.movies = []
        self.tv = []
        results = self.movie_soup.findAll('div',{'class':'item poster card'})
        for result in results:
            title = result.div.a['title']
            href = 'https://www.themoviedb.org' + result.div.a['href']
            try:
                img_url = result.div.img['data-src']
            except:
                img_url = 'No Image Avalable'
            date = result.findAll('span')[4].text
            overview = result.findAll('p',{'class':'overview'})[0].text
            res = []
            res.append(title)
            res.append(date)
            res.append(href)
            res.append(img_url)
            res.append(overview)
            self.movies.append(res)   
        results = self.tv_soup.findAll('div',{'class':'item poster card'})
        for result in results:
            title = result.div.a['title']
            href = 'https://www.themoviedb.org' + result.div.a['href']
            try:
                img_url = result.div.img['data-src']
            except:
                img_url = 'No Image Avalable'
            date = result.findAll('span')[4].text
            overview = result.findAll('p',{'class':'overview'})[0].text
            res = []
            res.append(title)
            res.append(date)
            res.append(href)
            res.append(img_url)
            res.append(overview)
            self.tv.append(res)
fr = open('.\searchphrase.txt','r')
search = fr.read()
sc = Search(search)
with open('.\movies.csv','w') as writeFile:
    writer = csv.writer(writeFile,delimiter='|')
    for i in sc.movies:
        writer.writerow(i)    
writeFile.close()
with open('.\\tv.csv','w') as wFile:
    writer = csv.writer(wFile,delimiter='|')
    for i in sc.tv:
        writer.writerow(i)    
wFile.close()
