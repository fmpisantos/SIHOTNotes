# TaskID - 28480/1
Transaction handling CI,CO,RM push notifications
## File & methods changed
 - sxmlinterface.cpp

- ci(const A_ZimmerBuchung* pZB, const A_Person* pPerson, t_System src, S_Bool isRestart, S_Bool appendExtendedGuestInfo)
- cip(const A_Person* person)
- co(const A_ZimmerBuchung* pZB, const A_Person* pPerson, t_System src)
- cop(const A_Person* person)
- rm(const A_ZimmerBuchung* pFrom, const A_ZimmerBuchung* pTo, const A_Person* ppFrom, const A_Person* ppTo)
- rmp(const A_Person* person, const S_ZimNrString& zielZimmer, const S_ZimNrString& _oldRoomNumber)

## Descrição
Dps de pesquisar onde são utilizados os metodos, estas funções são chamadas quando aida existe transação ou no post commit. Se forem chamadas no postcommit quer dizer que não existe necessidade de fazer rollback. 
Quando não é chamado do postcommit então a transação ainda está "aberta" ou seja pode ser utilizada.
