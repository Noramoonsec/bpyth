import csv
with open("numaralarveisimler.csv","r") as file:
    csvreader= csv.reader(file,delimiter =';')
    satirlar=list(csvreader)
    for satir in satirlar:
        birlesmis=str(satir[0])+str(satir[4])+str(satir[2])
        satir[0]=birlesmis
        del satir[2]
        del satir[3]
        with open("numisim1.csv","w",newline="") as file1:
            writer=csv.writer(file1)
            writer.writerows(satirlar)
                    


