
from operator import contains


hpo_id_label = {}


try:
    with open('phenotype_to_genes.txt','r') as file:
        line = file.readline()
        line = file.readline()
        
        while line:            
            contents = line.split('\t')
            
            if not contains(hpo_id_label, contents[0]):            
                hpo_id_label[contents[0]] = contents[1]                

            line = file.readline()

except Exception as e:
    print(e)

else:
    try:
        with open('id_label_sorted.tsv', 'w') as file:

            sorted_hpo_id = dict(sorted(hpo_id_label.items(), key=lambda item: item[1]))

            for id, label in sorted_hpo_id.items():
                file.write(f"{label}\t{id}\n")
            print("Success!")
    except Exception as e:
        print(e)
