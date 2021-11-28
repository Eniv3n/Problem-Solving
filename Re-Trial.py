import time
from selenium import webdriver


driver = webdriver.Chrome("/Users/pettermaeland/PycharmProjects/ProblemSolving/chromedriver")
driver.get("https://mitt.uib.no/groups")

def ButtonClicker():
    signIn = driver.find_element_by_id("idSIButton9")
    signIn.click()

loginMethod = driver.find_element_by_xpath("/html/body/div[2]/div[2]/div/div/div[1]/div/div[1]/div/div/div/div[2]/form[1]/div[4]/ul[1]/li[1]/a")
loginMethod.click()

time.sleep(4)

#Please enter the full name of the group you would like to navigate to in quotation marks below.
DesiredGroup = "Full Group Name Here"


#Login Process from username prompt
login = driver.find_element_by_id("i0116")


login.send_keys("Login Here") #Enter your login info, in quotationmarks.

ButtonClicker()
time.sleep(4)

password = driver.find_element_by_id("i0118")
password.send_keys("Password Here") #Enter your password, in quotationmarks.

ButtonClicker()
time.sleep(10)

ButtonClicker()
time.sleep(10)

selectedGroup = driver.find_element_by_xpath("//*[contains(text(),\'"+DesiredGroup+"\')]")
selectedGroup.click()

time.sleep(5)

announcements = driver.find_element_by_xpath("/html/body/div[2]/div[2]/div[2]/div[2]/nav/ul/li[2]/a")
announcements.click()