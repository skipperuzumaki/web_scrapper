from urllib.request import urlopen
from bs4 import BeautifulSoup as soup

class TvDetails:
    def __init__(self,URL):
        self.url = URL
        self.Data(URL)
        self.Parse()
    def Data(self,url):
        client = urlopen(self.url)
        html = client.read()
        client.close()
        self._soup = soup(html,'html.parser')
    def Parse(self):
        p = self._soup.findAll('ol',{'class':'people no_image'})[0].findAll('li',{'class':'profile'})
        people = []
        for person in p:
            pe = []
            pe.append(person.a.text)
            pe.append('https://www.themoviedb.org' + person.a['href'])
            people.append(pe)
        self.people = people
        season_list = 'https://www.themoviedb.org' + self._soup.findAll('section',{'class':'panel season'})[0].p.a['href']
        client = urlopen(season_list)
        html = client.read()
        client.close()
        seasonsoup = soup(html,'html.parser')
        seasons_raw = seasonsoup.findAll('div',{'class':'season'})
        seasons = []
        for season in seasons_raw:
            ssn = []
            ssn.append(season.findAll('h2')[0].a.text)
            ssn.append('https://www.themoviedb.org' + season.findAll('h2')[0].a['href'])
            ssn.append(season.findAll('h4')[0].text)
            seasons.append(ssn)
        self.seasons = seasons

'''
tv = TvDetails('https://www.themoviedb.org/tv/57041?language=en')
print(tv.people)
print(tv.seasons)
'''
