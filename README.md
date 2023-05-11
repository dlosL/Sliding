# Sliding
### Consegna:
Data una stringa formata solo da cifre, calcolare il prodotto più grande per una sua sottostringa contigua di cifre di lunghezza N.
**Ad esempio:**
- data in ingresso la stringa "1027839564", 
- il prodotto più grande per una serie di 3 cifre è 270 (9 * 5 * 6)
- e il prodotto più grande per una serie di 5 cifre è 7560 (7 * 8 * 3 * 9 * 5).
- Per l'ingresso "73167176531330624919225119674426574742355349194934", il prodotto più grande per una serie di 6 cifre è 23520.

Il codice precedente è scritto in C# ed è una classe pubblica. Questa classe contiene un metodo chiamato GetLargestProduct che prende una stringa di cifre e un intero che sta ad indicare l'intervallo di cifre di cui calcolare il prodotto più grande. Il metodo poi restituisce il prodotto più grande possibile delle cifre in intervallo specifico.Il metodo esegue alcuni controlli per verificare se l'intervallo specificato è valido o se la stringa di cifre contiene caratteri non validi attraverso un or.Il codice utilizza due cicli for annidati per guardare le cifre nell'intervallo specificato e calcolare il prodotto delle cifre. Il valore del prodotto viene confrontato con il valore del prodotto più grande trovato, e se è maggiore, il valore del prodotto più grande viene aggiornato per tenere traccia il nuovo prodotto più grande.

