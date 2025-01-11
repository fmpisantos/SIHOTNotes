# Sprint statistics (burndown chart)
Takes this classes as examples:
- stdc
- gstc

## A_GstStatistik::add
- A_TagesStatistik = Day statistics -> Day end stats
- A_UpdateHistory::datenAbstellen -> Data deactivate

## A_GstStatistik::set
- letzterAufenthalt -> Last stay 
### Questions:
- S_DBGstCounter
- S_Bool A_SalesPotential::doMonthlyCompatibilityHandling(const S_SalesPotential& _slsPotential, const long _roomNights, const S_ObjID& _gstObjID, S_Bool isRemove)


class A_ZStatistik : public A_TransMember
t_types

## TODO:
- Registar novos tipos para o sprint
- Pelos working times das tasks que pretencem a uma sprint registados entre o inicio e o fim da sprint é possivel calcular o burndown graph.
- Para não estar sempre a calcular guardamos entradas na tabela de estatitica sobre o que queremos mostrar.
- Podemos fazer os calculos ao começar o sprint review ou no final de cada dia.
- Se quiseremos ver o grafico durante a sprint (não sei se faz sentido) temos de ir gravando de dia a dia.
- Temos de gravar entradas para conseguir responder a todos os filtros. P.e:
    - Se quisermos ver um burndown por equipa, podemos gravar os efforts por dia e por equipa e utilizar estes para calcular o geral também
    - Em termos de performance podemos gravar também os efforts por dia gerais, mas isso nao devera ter um impacto assim tao bom
- Como será calculado pelos efforts postos durante uma sprint para as tasks que pertecem a said sprint podemos calcular para as sprints anteriores

### Em termos de codigo:
- Inicializar os novos tipos no class A_ZStatistik : public A_TransMember and void A_ZStatistik::initDef1()
- Adicionar funcionalidade ao start sprint review para calcular o necessário para fazer o display das  estatisticas
- Adicionar metodo que ao abrir o ecrã das estatisticas se estas não estiverem já calculadas (old sprints) devem então ser calculadas
    - Se esta validação for algo do genero, validar se existem entradas para todas os tipos na class A_ZStatistik se não existir recalcular as entradas em falta
- Criar metodo extensivel para que só se tenha de alterar este metodo para adicionar novas estatisticas + o novo tipo da class A_ZStatistik::t_types
- Test to see how long this takes to calculcate, if it takes too long we might want to calculate first the necessary information for the first view and then the rest async or on demand
- If on the workflow of the sprint review the burndown chart is not in the "first part" then we cal calculate what needs to be calculated on a separated "thread" on sprint review start and not on demand

## Exemplos:
- https://www.atlassian.com/agile/tutorials/burndown-charts

# Sprint efforts
We want to have some team related efforts for each of the sprints. And we want to make it easier to transitate tasks from sprint to sprint, 
meaning that the processo of adding effort for the task if needed needs to be improved

## Questions:
- Do we want to calculate this for old sprints (probably not)
- Do we want to split the efforts within the sprint equally (probably not, teams have different size + vacations etc)
- How do we want to display the new sprint efforts by team?
    - New "table" self filled at the begining equally between teams (calculated based on the number of team members) but it can and should be changed
    - In the future an integration can be made with HRWorks so that the calculation of effort per team can me more accurate by default
    - Some calculations can be made by team from the old sprints to see the % of plannedEffort/actual effort 
    (a percentage that indicates the amount of tasks finished given the initially planned before this is implemented we can simply use the overestimated effort/planned effort)
    - Each teamlead now has access to the effort field and that field represents the amount of effort that his team will have
