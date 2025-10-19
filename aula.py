dsafrom random import randint

temas = [
    'MOVER CHÃO',
    'BLOCOS',
    'MOEDAS',
    'CURVA',
    'MOVIMENTO LATERAL'
]

alunos = [
    'BRASILICIO',
    'DOUGLAS',
    'KAIO',
    'GUILHERME',
    'JADE',
    'TALITA',
    'ALANDERSON',
    'JULIO',
    'MARIA EUGENIA',
    'GABRIEL'
]
duplas = []

def definir_duplas():
    while len(alunos) > 1:
        a1 = alunos.pop(randint(0, len(alunos) - 1))
        a2 = alunos.pop(randint(0, len(alunos) - 1))
        duplas.append((a1, a2))
    if alunos:
        duplas[-1] = (duplas[-1][0], duplas[-1][1], alunos[0])

topicos = {}
def atribuir_tema():
    for a in duplas:
        tema = temas.pop(randint(0, len(temas) - 1))
        topicos[a] = tema
        
definir_duplas()
atribuir_tema()
for k, v in topicos.items():
    print(f'{k}: {v}')