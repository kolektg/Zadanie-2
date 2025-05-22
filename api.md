#  Dokumentacja API

Moduł `Zadanie 2.API` udostępnia zestaw RESTowych endpointów dla dwóch głównych zasobów: **Users** i **Resources**.

---

##  Autoryzacja

- JWT Token – generowany przy logowaniu
- Przekazywany jako `Authorization: Bearer {token}`

---

##  Endpointy użytkowników (`/api/users`)

| Metoda | Endpoint            | Opis                     |
|--------|---------------------|--------------------------|
| POST   | /register           | Rejestracja użytkownika  |
| POST   | /login              | Logowanie                |
| GET    | /me                 | Dane zalogowanego        |

---

##  Endpointy zasobów (`/api/resources`)

| Metoda | Endpoint            | Opis                     |
|--------|---------------------|--------------------------|
| GET    | /api/resources      | Lista zasobów            |
| GET    | /api/resources/{id} | Szczegóły zasobu         |
| POST   | /api/resources      | Dodanie nowego zasobu    |
| PUT    | /api/resources/{id} | Edycja zasobu            |
| DELETE | /api/resources/{id} | Usunięcie zasobu         |
