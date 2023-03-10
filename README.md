# DaDoIS_LW1-4
## Лабораторная работа №1
1. Выбрать поля базы данных для ввода и хранения информации о клиентах для выполнения лабораторной работы согласно номеру варианта.
2. Разработать схему данных в которой для элементов типа Список предусмотрены отдельные справочники. 
3. Реализовать схему данных в выбранной СУБД.
4. Разработать макет добавления, удаления и редактирования клиентов банка.
5. Разработать макет "Список клиентов", список отсортировать по фамилиям.
6. Создать подключение к базе данных.
7. На выбранном языке программирования создать модуль "Работа с клиентами", который реализует две формы, аналогичные разработанным макетам.
8. Предусмотреть проверку корректности введенных значений в каждом из полей с выдачей предупреждения в случае ошибки или незаполнения обязательного поля.
9. Добавить в базу данных через разработанную программу не менее 5 клиентов, включая собственные ФИО.

## Лабораторная работа №2
1. Для соответствующего своему варианту банка РБ выбрать для физических лиц:
   * депозитный вклад (отзывный) до востребования с ежемесячной выплатой процентов по вкладу.
   * депозитный срочный (безотзывный) вклад с выплатой процентов в конце срока.
2. В базе данных разработать справочник "План счетов" и внести в него номера счетов, их характеристики и наименования, для всех счетов, которые потребуются для обслуживания выбранных депозитных линий.
3. Разработать форму для заключения депозитного договора с физическим лицом, в которой предусмотреть контроль корректности вводимых данных.

   В форме предусмотреть:
   * вид депозита (из справочника);
   * номер договора;
   * вид валюты (из справочника);
   * дата начала и окончания депозитной программы;
   * срок договора;
   * сумма вклада;
   * процент по вкладу;
   * др. необходимые поля.
4. Данные о физическом лице должны быть связаны с модулем "Клиенты" *(см. лабораторную работу 1)*.

   При заключении договора должны создаваться как минимум два счета (для основной суммы и обслуживания процентов по депозиту) в соответствии с планом счетов:
   * номер счета (13-значный);
   * код счета из плана счетов (по нормам бух. учета банков РБ);
   * активность счета из плана счетов (актив., пассив., актив.-пассив.);
   * дебет, кредит, сальдо (остаток); 
   * название счета (ФИО клиента) и др. необходимые поля.
5. Предусмотреть счет фонда развития банка (СФРБ) со стартовым капиталом в 100 млрд. бел. рублей, с которого используются средства при кредитовании физлиц и на который зачисляются средства, полученные по депозитным программам.
6. Разработать процедуру "Закрытие банковского дня", которая будет изменять состояние счетов в соответствии с выбранными депозитными программами, считая, что выплата процентов происходит без задержки. Для контроля состояния счетов предусмотреть соответствующий отчет. При активных депозитных программах в нем должно быть минимум 6 счетов.

## Лабораторная работа №3
1. Для соответствующего своему варианту банка РБ выбрать для физических лиц:
   * кредит с ежемесячным погашением долга аннуитетным платежом.
   * кредит с ежемесячным погашением процентов по кредиту (дифференцированный) и выплатой полной суммы кредита в конце срока.
2. В базе данных разработать справочник "План счетов" и внести в него номера счетов, их характеристики и наименования, для всех счетов, которые потребуются для обслуживания выбранных кредитных линий.
3. Разработать форму для заключения кредитного договора с физическим лицом, в которой предусмотреть контроль корректности вводимых данных.
   
   В форме предусмотреть:
   * вид кредита (из справочника);
   * номер договора;
   * вид валюты (из справочника);
   * дата начала и окончания кредитной программы;
   * срок договора;
   * сумма кредита;
   * процент по кредиту;
   * др. необходимые поля.
4. Данные о физическом лице должны быть связаны с модулем "Клиенты" *(см. лабораторную работу 1)*.
   
   При заключении договора должны создаваться как минимум два счета (для основной суммы и обслуживания процентов по кредиту) в соответствии с планом счетов:
   * номер счета (13-значный);
   * код счета из плана счетов (по нормам бух. учета банков РБ);
   * активность счета из плана счетов (актив., пассив., актив.-пассив.);
   * дебет, кредит, сальдо (остаток); 
   * название счета (ФИО клиента) и др. необходимые поля.
5. Использовать из предыдущей работы счет фонда развития банка (СФРБ) со стартовым капиталом в 100 млрд. бел. рублей, с которого используются средства при кредитовании физлиц и на который зачисляются средства по депозитным программам.
6. Сформировать график начисления процентов (аннуитетный платеж с разбивкой по срокам и др.).
7. Разработать процедуру "Закрытие банковского дня", которая будет изменять состояние счетов в соответствии с выбранными депозитными программами, считая, что выплата процентов происходит без задержки. Для контроля состояния счетов предусмотреть соответствующий отчет. При двух активных кредитных программах в нем должно быть минимум 10 счетов (с учетом депозитных из предыдущей работы).

## Лабораторная работа №4
Разработать эмулятор банкомата, взаимодействующий с виртуальным банком из предыдущих работ. В качестве рабочего счета использовать разработанный в третьей работе кредитный счет.
Под банкоматом будем понимать автоматизированное устройство, позволяющее удаленно осуществлять операции, связанные с: 
* аутентификацией пользователя (держателя счета в банке); 
* просмотром текущего состояния счета; 
* снятием денег со счета; 
* осуществлением платежей (необязательно).

Все операции со счетом могут сопровождаться распечаткой чека, содержащего информацию о произведенном действии. В случае с осуществлением платежей распечатка производится автоматически, во всех остальных – по желанию клиента. 

Для выполнения вышеуказанных операций банкомат должен связываться с банком для выполнения проводок (см. предыдущие работы).

В данной работе необходимо решить задачу программной эмуляции работы банкомата, соответствующего приведенному описанию. 

Структура программы содержит две различные системы: протокол общения банка и банкомата, а также клиентский интерфейс. С точки зрения клиента, взаимодействие с эмуляцией банкомата должно выглядеть так же, как и в реальности: он должен иметь возможность начать работу с конкретной картой, которая должна быть идентифицирована устройством, а затем при помощи меню совершать в любой последовательности перечисленные выше денежные операции. 

В реальном банкомате идентификация карты происходит путем автоматического считывания ее номера. В данной работе в качестве этой процедуры будет использоваться введение номера карты с клавиатуры. Аутентификация, как правило, производится на основе введения клиентом так называемого PIN-кода (Personal Identification Number), который проверяется сервером банка на соответствие считанному номеру карты. В данной работе также будет использовано введение пользователем PIN-кода его карты с клавиатуры. 

При этом в качестве операции платежа будет рассматриваться оплата телекоммуникационных услуг операторов мобильной связи.
#   p i r i s B 
 