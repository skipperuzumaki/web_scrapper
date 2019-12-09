from urllib.request import urlopen
from bs4 import BeautifulSoup as soup

fr = open("seasons.txt",'r')
url = fr.read()
fr.close()
client = urlopen(self.url)
html = client.read()
client.close()
_soup = soup(html,'html.parser')
season_list = 'https://www.themoviedb.org' + _soup.findAll('section',{'class':'panel season'})[0].p.a['href']
fw = open("seasons.txt",'w')
fr.write(season_list)
fw.close()
