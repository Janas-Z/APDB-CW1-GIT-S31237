Dlaczego merge w Zadaniu 5 nie był fast-forward?
Ponieważ po utworzeniu gałęzi feature-max, na gałęzi main 
również pojawił się nowy commit. Historia się rozgałęziła, więc Git 
musiał stworzyć nowy "Merge Commit", aby połączyć obie ścieżki.

Kiedy Git wykona fast-forward, a kiedy powstaje merge commit?

Fast-forward występuje, gdy gałąź główna nie zmieniła się od czasu utworzenia gałęzi bocznej – Git tylko przesuwa wskaźnik. Merge commit powstaje, gdy obie gałęzie ruszyły do przodu i trzeba stworzyć nowy węzeł łączący obie historie.

Czym w praktyce różni się merge od rebase?

Merge zachowuje pełną historię z wszystkimi rozgałęzieniami. Rebase "przepisuje" historię, ustawiając commity z gałęzi bocznej na samym końcu aktualnej gałęzi głównej, co daje czystą, liniową historię.

W jaki sposób został rozwiązany konflikt w Twoim repozytorium?

Konflikt wystąpił w pliku Program.cs w linii definiującej tablicę danych. Rozwiązałem go ręcznie poprzez usunięcie znaczników konfliktu (<<<<<<<, =======, >>>>>>>) i zdecydowałem się zachować wersję pochodzącą z gałęzi feature-conflict, odrzucając zmiany z gałęzi main. Po edycji kodu upewniłem się, że aplikacja kompiluje się poprawnie, a następnie zatwierdziłem zmianę nowym commitem.