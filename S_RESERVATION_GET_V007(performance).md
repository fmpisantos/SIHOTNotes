# After change 
race duration: 2660.8649ms, cpu usage 1546.875ms (1531.25ms user, 15.625ms kernel, 1113.9899ms wait, SDB 1737.9505[ado 1100.0841 / lockwait 1.9411]ms, XML 5.078ms) @PT-FMSANTOS-01 [2024-09-09T11:01:18,550]
system cpu usage: overall 3.4652% (3.1703% user, 0.2949% kernel)
trace info: 58604 calls, trace overhead (real time) 2.823513 milliseconds (0,048180 microseconds/call), time to generate trace info: 3.4749ms.
   real time   /Co%/ n calls / time per call  / max per call  / stralloc/class::method - section
      2.658,252/100/        1/   2.658,251712[   2.658,251712]/        0 SIF_CrossbowServer::doProcessService
      2.033,311/ 97/        1/   2.033,311319[   2.033,311319]/   652819 +---ServiceInstance::getOutput
      1.498,909/ 95/       16/      93,681816[     118,668203]/   401253 |   +---BO_Base::relation(BO_PERSON,packages,0) {48 objects}
        584,904/ 84/       96/       6,092754[      30,529130]/   359500 |   |   +---S_Fixleistung::getPreisVonBis1()
        466,425/ 98/     3296/       0,141512[       0,660872]/   270404 |   |   |   +---A_Preis::calculateEX1
        455,276/ 60/     3296/       0,138130[       0,656822]/   266436 |   |   |   |   +---A_Preis::doCalculateEX1
        155,670/ 93/     3296/       0,047230[       0,278811]/    99504 |   |   |   |   |   +---A_Preis::calculateEX1
        145,384/ 54/     3296/       0,044109[       0,275509]/    89616 |   |   |   |   |   |   +---A_Preis::doCalculateEX1
         77,629/   /     3296/       0,023552[       0,119985]/    35232 |   |   |   |   |   |   |   |   A_Preis::taxenUndProvUms
          0,692/   /      824/       0,000840[       0,011853]/        0 |   |   |   |   |   |   |   +---A_Preis::calcOffersAndPrerules
        117,835/  4/     3296/       0,035751[       0,511035]/    52476 |   |   |   |   |   +---A_Preis::taxenUndProvUms
          4,802/ 65/      256/       0,018758[       0,044162]/     2024 |   |   |   |   |   |   +---A_Preis::calculateEX1
          3,108/ 10/      256/       0,012139[       0,032119]/     1512 |   |   |   |   |   |   |   +---A_Preis::doCalculateEX1
          0,307/   /      200/       0,001533[       0,003102]/        0 |   |   |   |   |   |   |   |   +---S_PreCache::get()
         22,310/   /     3296/       0,006769[       0,227858]/    42848 |   |   |   +---S_ZimNr::buildData()
        171,537/   /       96/       1,786842[       2,441587]/     1536 |   |   |   S_DB<zim>::seek()
        165,330/ 99/       96/       1,722191[       3,800480]/    12442 |   |   +---A_Preis::calculateEX1
        164,329/ 95/       96/       1,711757[       3,792706]/    12154 |   |   |   +---A_Preis::doCalculateEX1
        143,390/   /       48/       2,987290[       3,474852]/      816 |   |   |   |   |   S_DB<gst>::seekObj()
          5,574/ 93/       96/       0,058061[       0,089969]/     2928 |   |   |   |   +---A_Preis::calculateEX1
          5,163/ 50/       96/       0,053777[       0,084013]/     2640 |   |   |   |   |   +---A_Preis::doCalculateEX1
          2,558/   /       96/       0,026644[       0,041788]/     1056 |   |   |   |   |   |   +---A_Preis::taxenUndProvUms
          4,903/   /       96/       0,051075[       0,428862]/     1570 |   |   |   |   |   A_Preis::taxenUndProvUms
          1,149/   /       48/       0,023947[       0,033731]/     1008 |   |   |   |   |   S_DB<gst>::read()
          0,766/   /       48/       0,015962[       0,025456]/     1152 |   |   |   |   +---S_DB<gst>::reDecode()
        152,911/   /       48/       3,185644[       3,982127]/     1729 |   |   |   S_DB<res>::seek()
        143,941/   /       48/       2,998775[       3,605891]/      816 |   |   |   S_DB<gst>::seekObj()
        103,447/   /       51/       2,028370[       2,461769]/      153 |   |   |   S_DB<zbu>::firstRow(S_Bool)
         52,164/   /       24/       2,173513[       2,974401]/       96 |   |   |   S_DB<gko>::seek()
         26,434/   /       16/       1,652139[       2,242450]/       83 |   |   |   S_DB<fgpo>::first(S_Bool)
          7,835/   /        4/       1,958752[       1,986845]/       20 |   |   |   S_DB<regpath>::first(S_Bool)
          4,781/   /        4/       1,195156[       1,311530]/       14 |   |   |   S_DB<grp>::first(S_Bool)
          3,194/   /       48/       0,066552[       0,097811]/      160 |   |   |   S_DB<fgpo>::next()
          2,785/   /       48/       0,058014[       0,107954]/      960 |   |   |   A_Leistung::set(const S_LstNr &lstnr, const A_Person *per)
          1,811/   /       96/       0,018869[       0,035810]/     1824 |   |   |   S_DB<zim>::read()
          1,605/   /       48/       0,033438[       0,078127]/     1776 |   |   |   S_DB<res>::read()
          1,335/   /      147/       0,009079[       0,025404]/     1911 |   |   |   S_ZimNr::buildData()
          1,239/   /       48/       0,025819[       0,037113]/     1248 |   |   |   S_DB<gst>::read()
          0,830/   /       48/       0,017286[       0,022705]/     1392 |   |   |   S_DB<gst>::reDecode()
          0,707/   /       16/       0,044162[       0,051323]/       36 |   |   |   S_DB<grp>::next()
          0,613/   /        1/       0,612712[       0,612712]/        4 |   |   |   S_DB<regent>::first(S_Bool)
          0,448/ 60/       24/       0,018683[       0,030715]/      624 |   |   +---A_Konto::readKonto(long,S_DBGko*)
          0,268/   /       24/       0,011156[       0,015307]/      432 |   |   |   +---S_DB<gko>::reDecode()
          0,414/   /     1240/       0,000334[       0,031939]/        0 |   |   |   A_Konto::destruct()
          0,323/   /       16/       0,020206[       0,035360]/        0 |   |   |   A_TransIter(A_Fixleistung)
          0,266/   /       48/       0,005532[       0,013369]/      400 |   |   +---S_DB<fgpo>::read()
        248,903/ 98/        1/     248,902859[     248,902859]/    81961 |   +---BO_Base::relation(BO_RES,packages,0) {3 objects}
        116,078/100/        6/      19,346324[      95,887802]/    10589 |   |   +---A_Preis::calculateEX1
        115,932/ 98/        6/      19,322010[      95,818995]/    10568 |   |   |   +---A_Preis::doCalculateEX1
         77,593/ 93/        6/      12,932190[      68,158229]/     7372 |   |   |   |   +---A_Preis::taxenUndProvUms
         28,151/   /       16/       1,759428[       2,480546]/       64 |   |   |   |   |   |   S_DB<regpath>::first(S_Bool)
          8,552/   /        4/       2,137967[       2,223486]/       27 |   |   |   |   |   |   S_DB<lsttxt>::first(S_Bool)
          6,600/   /        7/       0,942921[       1,281238]/       53 |   |   |   |   |   |   S_DB<htxt>::first(S_Bool)
          5,887/ 98/        8/       0,735901[       5,700945]/      141 |   |   |   |   |   +---A_Preis::calculateEX1
          5,780/ 94/        8/       0,722474[       5,676429]/      125 |   |   |   |   |   |   +---A_Preis::doCalculateEX1
          4,805/   /        3/       1,601699[       2,185100]/       12 |   |   |   |   |   |   |   |   S_DB<regpath>::first(S_Bool)
          0,643/ 93/        6/       0,107108[       0,634114]/       10 |   |   |   |   |   |   |   +---S_PreCache::get()
          0,595/   /        1/       0,594547[       0,594547]/        0 |   |   |   |   |   |   |   |   +---S_DB<regpath>::first(S_Bool)
          5,050/ 98/        1/       5,049837[       5,049836]/       60 |   |   |   |   |   +---S_VarStkaCache::initCache(33)
          4,174/   /        2/       2,086944[       2,136125]/        0 |   |   |   |   |   |   |   S_DB<audittrail>::lastRow()
          0,771/   /        1/       0,771320[       0,771320]/       10 |   |   |   |   |   |   +---S_DB<stka>::first(S_Bool)
          3,687/   /        3/       1,228868[       1,253277]/       11 |   |   |   |   |   |   S_DB<ryth>::first(S_Bool)
          3,638/   /      291/       0,012502[       0,142935]/     2030 |   |   |   |   |   |   S_DB<txt>::next()
          3,264/   /        1/       3,263641[       3,263641]/       18 |   |   |   |   |   |   S_DB<htxt>::seek()
          1,558/100/        1/       1,558440[       1,558440]/        3 |   |   |   |   |   +---S_TimeStamp::getTimeStamp(long hotelNr, const S_String &typ)
          1,555/   /        1/       1,555335[       1,555335]/        2 |   |   |   |   |   |   +---S_DB<htxt>::seek()
          1,506/   /        2/       0,753212[       0,859554]/        7 |   |   |   |   |   |   S_DB<txt>::first(S_Bool)
          0,992/   /        3/       0,330632[       0,335753]/        0 |   |   |   |   |   |   S_DB<ryth>::~S_DB()
          0,889/ 72/        1/       0,889226[       0,889226]/      123 |   |   |   |   |   +---S_ReaderWriterLockForCaches::lockForReading(VARSTKA_CACHE,[33, 250, 125])
          0,643/   /        1/       0,643042[       0,643042]/        4 |   |   |   |   |   |   +---S_DB<regpath>::first(S_Bool)
          0,818/   /        1/       0,818025[       0,818025]/       11 |   |   |   |   |   |   S_DB<stka>::first(S_Bool)
          0,676/   /        1/       0,676219[       0,676219]/        4 |   |   |   |   |   |   S_DB<regent>::first(S_Bool)
          0,388/   /       27/       0,014380[       0,022297]/      184 |   |   |   |   |   |   S_DB<htxt>::next()
          0,348/   /        5/       0,069549[       0,328954]/        0 |   |   |   |   |   +---S_DB<htxt>::~S_DB()
         11,249/   /        7/       1,606949[       2,088210]/       36 |   |   |   |   |   S_DB<regpath>::first(S_Bool)
          8,871/   /        3/       2,957151[       3,137501]/       51 |   |   |   |   |   S_DB<gst>::seekObj()
          5,279/ 99/        6/       0,879829[       4,241033]/      909 |   |   |   |   +---A_Preis::calculateEX1
          5,251/ 88/        6/       0,875178[       4,235600]/      891 |   |   |   |   |   +---A_Preis::doCalculateEX1
          2,006/   /        3/       0,668616[       0,716423]/       16 |   |   |   |   |   |   |   S_DB<regpath>::first(S_Bool)
          1,161/   /        6/       0,193571[       0,453814]/      580 |   |   |   |   |   |   |   A_Preis::taxenUndProvUms
          0,795/   /        1/       0,795490[       0,795490]/        9 |   |   |   |   |   |   |   S_DB<prefix>::first(S_Bool)
          0,673/   /        1/       0,673480[       0,673480]/        4 |   |   |   |   |   |   +---S_DB<regent>::first(S_Bool)
          2,751/   /        2/       1,375456[       1,639507]/        2 |   |   |   |   |   S_DB<prerulehead>::firstRow(S_Bool)
          2,708/   /        3/       0,902725[       0,957139]/       28 |   |   |   |   |   S_DB<htxt>::first(S_Bool)
          1,284/   /        2/       0,641990[       0,664408]/        8 |   |   |   |   |   S_DB<regent>::first(S_Bool)
          1,247/100/        1/       1,246746[       1,246746]/        3 |   |   |   |   +---S_TimeStamp::getTimeStamp(long hotelNr, const S_String &typ)
          1,242/   /        1/       1,242463[       1,242463]/        2 |   |   |   |   |   +---S_DB<htxt>::seek()
          0,888/   /        1/       0,888360[       0,888360]/        6 |   |   |   |   |   S_DB<rabatt>::first(S_Bool)
          0,743/   /        1/       0,743454[       0,743454]/        6 |   |   |   |   |   S_DB<txt>::first(S_Bool)
          0,701/   /       45/       0,015576[       0,034976]/      132 |   |   |   |   |   S_DB<rabatt>::next()
          0,282/   /        1/       0,282083[       0,282083]/        0 |   |   |   |   +---S_DB<prerulehead>::~S_DB()
         91,728/ 99/        6/      15,287954[      51,263299]/    69804 |   |   +---S_Fixleistung::getPreisVonBis1()
         90,797/ 99/      206/       0,440764[       1,237587]/    69128 |   |   |   +---A_Preis::calculateEX1
         90,152/ 81/      206/       0,437630[       1,233945]/    68880 |   |   |   |   +---A_Preis::doCalculateEX1
         39,633/ 98/      206/       0,192395[       0,573081]/    24390 |   |   |   |   |   +---A_Preis::calculateEX1
         38,981/ 84/      206/       0,189227[       0,568896]/    23772 |   |   |   |   |   |   +---A_Preis::doCalculateEX1
         32,901/ 14/      206/       0,159715[       0,526206]/    19446 |   |   |   |   |   |   |   +---A_Preis::taxenUndProvUms
          4,739/ 64/      256/       0,018512[       0,044040]/     2024 |   |   |   |   |   |   |   |   +---A_Preis::calculateEX1
          3,054/ 10/      256/       0,011928[       0,036728]/     1512 |   |   |   |   |   |   |   |   |   +---A_Preis::doCalculateEX1
          0,300/   /      200/       0,001502[       0,002571]/        0 |   |   |   |   |   |   |   |   |   |   +---S_PreCache::get()
         33,242/ 14/      206/       0,161367[       0,543529]/    19446 |   |   |   |   |   +---A_Preis::taxenUndProvUms
          4,712/ 64/      256/       0,018406[       0,044279]/     2024 |   |   |   |   |   |   +---A_Preis::calculateEX1
          3,036/ 10/      256/       0,011859[       0,034721]/     1512 |   |   |   |   |   |   |   +---A_Preis::doCalculateEX1
          0,310/   /      200/       0,001548[       0,008172]/        0 |   |   |   |   |   |   |   |   +---S_PreCache::get()
         19,880/   /       14/       1,420003[       2,068265]/       64 |   |   |   S_DB<regpath>::first(S_Bool)
          8,358/   /        3/       2,785868[       3,206992]/       51 |   |   |   S_DB<gst>::seekObj()
          2,466/   /        1/       2,466202[       2,466202]/       39 |   |   |   S_DB<gst>::seek()
          1,879/   /        1/       1,878734[       1,878734]/        6 |   |   |   S_DB<lsttxt>::first(S_Bool)
          1,817/   /        1/       1,816564[       1,816564]/       15 |   |   |   S_DB<rgpo>::first(S_Bool)
          1,339/   /        2/       0,669286[       0,692582]/        8 |   |   |   S_DB<regent>::first(S_Bool)
          1,263/100/        1/       1,262942[       1,262942]/        3 |   |   +---S_TimeStamp::getTimeStamp(long hotelNr, const S_String &typ)
          1,259/   /        1/       1,259162[       1,259162]/        2 |   |   |   +---S_DB<htxt>::seek()
         97,166/ 99/        2/      48,583232[      97,235225]/    27083 |   +---BO_Base::relation(BO_RES,namelistGrouped,0) {4 objects}
         85,427/ 99/        4/      21,356674[      76,032446]/    26568 |   |   +---BO_NamelistGroup::loadFromObject()
         63,319/ 99/       16/       3,957438[      55,716936]/    23942 |   |   |   +---BO_NamelistGroup::loadFromObject() if ( g.objID.valid() )
         48,375/ 60/        4/      12,093856[      48,434971]/    23687 |   |   |   |   +---S_ZimNr::buildData()
         11,764/   /      581/       0,020248[       0,137901]/     1737 |   |   |   |   |   |   S_DB<zim>::next()
          6,685/   /      836/       0,007996[       0,033397]/     2505 |   |   |   |   |   |   S_DB<zimdat>::next()
          3,049/   /        3/       1,016240[       1,937499]/       12 |   |   |   |   |   |   S_DB<regpath>::first(S_Bool)
          2,408/   /        3/       0,802526[       0,897565]/        8 |   |   |   |   |   |   S_DB<zim>::first(S_Bool)
          2,024/   /      581/       0,003483[       0,025215]/     4384 |   |   |   |   |   |   S_DB<zim>::read()
          1,779/   /        2/       0,889489[       0,913571]/       24 |   |   |   |   |   |   S_DB<htxt>::first(S_Bool)
          0,891/   /        1/       0,891116[       0,891116]/        5 |   |   |   |   |   |   S_DB<zimdat>::first(S_Bool)
          0,622/   /        1/       0,621833[       0,621833]/        2 |   |   |   |   |   +---S_DB<jou>::first(S_Bool)
          9,409/   /        4/       2,352301[       2,527184]/       14 |   |   |   |   |   S_DB<zbu>::firstRow(S_Bool)
          4,118/   /        2/       2,059131[       2,108698]/       12 |   |   |   |   |   S_DB<regpath>::first(S_Bool)
          0,679/   /        1/       0,679356[       0,679356]/        4 |   |   |   |   +---S_DB<regent>::first(S_Bool)
         21,023/ 91/       16/       1,313937[      19,647373]/     2306 |   |   |   +---BO_Person::loadFromObject( const S_Grp &_grp, S_Bool _isDummy /* = S_False */ )
         12,026/   /        6/       2,004327[       2,113764]/       36 |   |   |   |   |   S_DB<regpath>::first(S_Bool)
          4,413/ 91/       16/       0,275791[       4,151621]/      355 |   |   |   |   +---BO_Person::loadFromObject() Block2
          4,036/   /        2/       2,017932[       2,031607]/        8 |   |   |   |   |   +---S_DB<regpath>::first(S_Bool)
          1,899/   /        3/       0,633003[       0,702236]/       12 |   |   |   |   |   S_DB<regent>::first(S_Bool)
          0,792/   /        1/       0,792106[       0,792106]/        6 |   |   |   |   +---S_DB<txt>::first(S_Bool)
          8,028/   /        4/       2,006971[       2,162575]/       20 |   |   |   S_DB<regpath>::first(S_Bool)
          2,216/ 87/        1/       2,216005[       2,216005]/      363 |   |   +---A_Reservierung::allePersonen
          1,218/   /        1/       1,218412[       1,218412]/        3 |   |   |   |   S_DB<grp>::first(S_Bool)
          0,713/   /       16/       0,044564[       0,071157]/       45 |   |   |   +---S_DB<grp>::next()
          0,782/   /        1/       0,782135[       0,782135]/        4 |   |   +---S_DB<regent>::first(S_Bool)
         52,706/ 98/       16/       3,294127[       8,422051]/     1081 |   +---BO_Base::relation(BO_PERSON,getRegistrationCard,0) {16 objects}
         46,759/   /       32/       1,461207[       1,842041]/        0 |   |   |   S_DB<blobhead>::first(S_Bool)
          4,872/   /        3/       1,623973[       2,091757]/       12 |   |   +---S_DB<regpath>::first(S_Bool)
         24,047/100/        1/      24,046851[      24,046851]/     8378 |   +---preAccess(BO_RES,forecastrategross)
         23,365/ 98/        1/      23,364849[      23,364849]/     8348 |   |   +---BO_ResBase::getRateForecast
         20,256/ 93/        1/      20,255506[      20,255506]/     8210 |   |   |   +---A_PreCalcData::getReservierungsInfo(dataObject&, const retrieveMask, long, const S_ObjID&, const S_Date&, const S_Date&)
         10,610/   /     1020/       0,010402[       0,042617]/     4056 |   |   |   |   |   S_DB<precalcdata>::next()
          7,776/   /        6/       1,296074[       1,460197]/       26 |   |   |   |   |   S_DB<precalcdata>::first(S_Bool)
          0,441/   /     1020/       0,000433[       0,007757]/        2 |   |   |   |   +---S_DB<precalcdata>::read()
          2,682/   /        2/       1,341184[       2,010306]/        8 |   |   |   +---S_DB<regpath>::first(S_Bool)
          0,641/   /        1/       0,640985[       0,640985]/        4 |   |   +---S_DB<regpath>::first(S_Bool)
         16,302/ 96/       16/       1,018849[       5,860069]/      951 |   +---BO_Base::relation(BO_PERSON,guest,0) {4 objects}
         15,631/ 97/        4/       3,907658[       5,758151]/      495 |   |   +---A_Person::getGast()
         13,092/   /        4/       3,273109[       3,567375]/      153 |   |   |   |   S_DB<gst>::seek()
          1,997/   /        1/       1,996911[       1,996911]/        4 |   |   |   +---S_DB<regpath>::first(S_Bool)
         13,549/ 93/        1/      13,548627[      13,548626]/      992 |   +---preAccess(BO_RES,forecastnoofadults)
          8,154/ 94/        1/       8,154313[       8,154313]/      670 |   |   +---A_Reservierung::allePersonen
          4,493/   /        3/       1,497752[       1,976280]/       16 |   |   |   |   S_DB<regpath>::first(S_Bool)
          1,194/   /        1/       1,193648[       1,193648]/        5 |   |   |   |   S_DB<grp>::first(S_Bool)
          0,704/ 83/       16/       0,043983[       0,637114]/      146 |   |   |   +---S_DB<grp>::read()
          0,582/   /        1/       0,581547[       0,581547]/        4 |   |   |   |   +---S_DB<regpath>::first(S_Bool)
          0,648/   /       16/       0,040477[       0,053732]/       45 |   |   |   |   S_DB<grp>::next()
          0,589/   /        1/       0,589126[       0,589126]/        4 |   |   |   +---S_DB<regent>::first(S_Bool)
          2,940/   /        1/       2,939544[       2,939544]/        6 |   |   |   S_DB<res>::seekObj()
          0,794/   /        1/       0,794312[       0,794312]/        6 |   |   |   S_DB<txt>::first(S_Bool)
          0,776/   /        1/       0,776188[       0,776188]/        4 |   |   +---S_DB<htxt>::first(S_Bool)
          8,020/ 95/        1/       8,019628[       8,019628]/      265 |   +---BO_Base::relation(BO_RES,orderer,0) {1 objects}
          4,771/   /        3/       1,590182[       2,191806]/       12 |   |   |   S_DB<regpath>::first(S_Bool)
          2,831/   /        1/       2,830670[       2,830670]/       17 |   |   +---S_DB<gst>::seekObj()
          5,439/   /        1/       5,439239[       5,439239]/        6 |   |   S_DB<txt>::first(S_Bool)
          2,936/ 95/        1/       2,935872[       2,935872]/      193 |   +---BO_Base::relation(BO_RES,travelAgency,0) {1 objects}
          2,778/   /        1/       2,778041[       2,778041]/       17 |   |   +---S_DB<gst>::seekObj()
          2,045/   /        1/       2,044839[       2,044839]/        4 |   |   S_DB<regpath>::first(S_Bool)
          1,566/ 99/        1/       1,566143[       1,566142]/       12 |   +---S_TimeStamp::getTimeStamp(long hotelNr, const S_String &typ)
          1,552/   /        1/       1,552346[       1,552346]/       10 |   |   +---S_DB<htxt>::seek()
          0,401/   /      239/       0,001679[       0,018919]/        0 |   |   Intercept::ReadFile(1776[D:\src\1100.03.01\env\DE.txt])
          0,395/   /      219/       0,001806[       0,020159]/        0 |   |   Intercept::ReadFile(1776[D:\src\1100.03.01\env\EN.txt])
          0,309/   /      219/       0,001412[       0,008990]/        0 |   |   Intercept::ReadFile(1776[D:\src\1100.03.01\env\en.txt])
          0,308/   /        2/       0,154008[       0,298515]/        0 |   +---Intercept::ReadFile(1772[D:\src\1100.03.01\env\etc\cat\EN\interfaceserver])
        607,401/100/        1/     607,401043[     607,401043]/   102288 +---ServiceInstance::readInput
        540,524/ 93/        1/     540,523558[     540,523557]/    96096 |   +---S_LstCache::initCache(33) {cacheSize = 825, avglen = 3.0529, maxlen = 17, readFlag = delayed, incremental stka load = yes, reason = ts.updated,not in cache}
        142,583/   /      825/       0,172828[       0,630057]/     3296 |   |   |   S_DB<lst>::next()
        131,477/   /        1/     131,477368[     131,477368]/        6 |   |   |   S_DB<lst>::first(S_Bool)
         51,955/   /     3437/       0,015116[       0,727773]/    10308 |   |   |   S_DB<pre2>::next()
         46,954/   /        1/      46,954206[      46,954206]/       12 |   |   |   S_DB<htxt>::first(S_Bool)
         23,833/   /     2654/       0,008980[       0,039882]/     7959 |   |   |   S_DB<pre2add>::next()
         22,153/   /        1/      22,152801[      22,152801]/      687 |   |   |   S_DB<pre2>::first(S_Bool)
         18,683/ 15/      825/       0,022646[       2,982327]/     6308 |   |   +---S_DB<lst>::read()
          2,872/   /        1/       2,872480[       2,872480]/        4 |   |   |   +---S_DB<regpath>::first(S_Bool)
         12,931/   /      652/       0,019833[       0,595448]/     2112 |   |   |   S_DB<blobdata>::next()
         11,660/   /        1/      11,659684[      11,659684]/     5133 |   |   |   S_DB<pre2add>::first(S_Bool)
          6,865/   /      651/       0,010545[       0,079284]/     1950 |   |   |   S_DB<blobhead>::next()
          5,313/   /        6/       0,885472[       2,404285]/       12 |   |   |   S_DB<regpath>::first(S_Bool)
          4,869/   /        2/       2,434478[       2,979035]/        1 |   |   |   S_DB<audittrail>::lastRow()
          4,735/   /     3437/       0,001378[       0,011868]/        0 |   |   |   S_DB<pre2>::read()
          4,228/   /        1/       4,228372[       4,228372]/     1307 |   |   |   S_DB<blobdata>::first(S_Bool)
          3,327/   /      137/       0,024282[       0,395495]/     1088 |   |   |   S_DB<htxt>::next()
          2,306/   /      239/       0,009649[       0,023465]/      714 |   |   |   S_DB<lstlink>::next()
          2,233/   /        1/       2,233068[       2,233068]/     1307 |   |   |   S_DB<blobhead>::first(S_Bool)
          1,719/ 71/        1/       1,718637[       1,718637]/      153 |   |   +---S_ReaderWriterLockForCaches::lockForReading(LST_CACHE,[33, 250, 125])
          1,227/   /        2/       0,613638[       0,677563]/        8 |   |   |   +---S_DB<regpath>::first(S_Bool)
          1,407/   /        1/       1,406723[       1,406723]/      155 |   |   |   S_DB<lstlink>::first(S_Bool)
          0,892/   /     2654/       0,000336[       0,005773]/        2 |   |   |   S_DB<pre2add>::read()
          0,580/   /        1/       0,579635[       0,579635]/        4 |   |   |   S_DB<regent>::first(S_Bool)
          0,378/   /        1/       0,378279[       0,378279]/      639 |   |   |   S_DB<lst>::setBestKey()
          0,339/   /      651/       0,000520[       0,002024]/        0 |   |   +---S_DB<blobhead>::read()
         12,230/ 94/        1/      12,230217[      12,230216]/      804 |   +---S_PreCache::initCache(33) {0 services, 0 records, maxArrLen = 0, minDate=01.12.2023}
          5,378/   /        2/       2,689106[       2,758425]/        0 |   |   |   S_DB<audittrail>::lastRow()
          2,828/   /        2/       1,414206[       1,494490]/        2 |   |   |   S_DB<pre>::first(S_Bool)
          1,924/   /        3/       0,641332[       0,689850]/        8 |   |   |   S_DB<regpath>::first(S_Bool)
          1,094/ 67/        1/       1,093986[       1,093986]/      123 |   |   +---S_ReaderWriterLockForCaches::lockForReading(PRE_CACHE,[33, 250, 125])
          0,738/   /        1/       0,738133[       0,738133]/        4 |   |   |   +---S_DB<regpath>::first(S_Bool)
          0,270/   /        2/       0,135231[       0,265633]/      468 |   |   +---S_DB<pre>::setBestKey()
         10,100/ 98/        1/      10,099645[      10,099645]/       77 |   +---BO_Res::loadFromObject()
          7,761/   /        5/       1,552107[       1,870159]/        5 |   |   |   S_DB<txt>::seek()
          2,103/   /        1/       2,103134[       2,103134]/        4 |   |   +---S_DB<regpath>::first(S_Bool)
          9,904/100/        7/       1,414831[       1,698403]/       46 |   +---S_TimeStamp::getTimeStamp(long hotelNr, const S_String &typ)
          9,859/   /        7/       1,408474[       1,684148]/       36 |   |   +---S_DB<htxt>::seek()
          9,620/   /       11/       0,874526[       2,596356]/       36 |   |   S_DB<regpath>::first(S_Bool)
          5,405/ 98/        1/       5,405107[       5,405107]/      113 |   +---BO_Transaction::BO_Transaction
          2,891/ 90/        1/       2,891049[       2,891049]/       56 |   |   +---BO_Base::cloneTree
          2,616/   /        2/       1,307845[       2,029696]/        4 |   |   |   +---S_DB<regpath>::first(S_Bool)
          1,230/   /        2/       0,615107[       0,615618]/        0 |   |   |   S_DB<regpath>::first(S_Bool)
          1,182/ 54/        1/       1,181744[       1,181744]/       29 |   |   +---A_TransCntrl::begin() :- open transaction
          0,638/   /        1/       0,637562[       0,637562]/        4 |   |   |   +---S_DB<regpath>::first(S_Bool)
          4,238/   /        1/       4,238092[       4,238092]/        9 |   |   S_DB<res>::seekObj()
          3,864/ 92/        1/       3,863582[       3,863582]/      173 |   +---BO_Transaction::~BO_Transaction
          2,327/   /        3/       0,775567[       0,785520]/        8 |   |   |   S_DB<regpath>::first(S_Bool)
          0,747/ 93/        1/       0,746849[       0,746848]/       44 |   |   +---BO_Base::updateAfterFunctionExecution
          0,691/   /        1/       0,691123[       0,691123]/        4 |   |   |   +---S_DB<regpath>::first(S_Bool)
          0,482/ 98/        1/       0,482144[       0,482143]/        1 |   |   +---BO_Transaction::close
          0,471/   /        1/       0,470700[       0,470700]/        0 |   |   |   +---A_TransCntrl::end() :- close transaction
          2,610/   /        1/       2,610478[       2,610478]/     4340 |   |   Service::createServiceFromXML
          1,906/   /        1/       1,906025[       1,906025]/        8 |   |   S_DB<lsttxt>::first(S_Bool)
          1,619/ 99/        1/       1,618577[       1,618577]/       16 |   +---BO_Base::initDefaultsByConfig
          1,597/ 99/        1/       1,597360[       1,597360]/       12 |   |   +---S_TimeStamp::getTimeStamp(long hotelNr, const S_String &typ)
          1,587/   /        1/       1,587341[       1,587341]/       10 |   |   |   +---S_DB<htxt>::seek()
          1,433/   /        1/       1,432641[       1,432641]/        5 |   |   S_DB<txt>::seek()
          1,295/   /        2/       0,647321[       0,697935]/        8 |   |   S_DB<regent>::first(S_Bool)
          0,766/   /        1/       0,766251[       0,766251]/       12 |   +---S_DB<htxt>::first(S_Bool)
         13,709/   /      451/       0,030396[       0,402942]/        0 |   Intercept::WriteFile(16[])
          1,127/100/        1/       1,126968[       1,126967]/      116 +---ServiceInstance::invokeSequence
          0,581/ 68/        1/       0,580608[       0,580608]/       45 |   +---BO_Transaction::BO_Transaction
          0,394/   /        1/       0,394205[       0,394205]/        0 |   |   +---A_TransCntrl::begin() :- open transaction
          0,544/ 83/        1/       0,544346[       0,544346]/       71 |   +---BO_Transaction::~BO_Transaction
          0,453/ 99/        1/       0,452950[       0,452950]/        1 |   |   +---BO_Transaction::close
          0,450/   /        1/       0,449639[       0,449639]/        0 |   |   |   +---A_TransCntrl::end() :- close transaction
          0,723/   /        1/       0,722957[       0,722957]/        0 +---S_DB<regpath>::first(S_Bool)
S_DBDriver
index:	67 (200)
first:	151 (449)
seek:	298 (558)
next:	11580 (14635)
lock:	1 (499)
unLock:	1 (492)
remove:	0 (7)
read:	11948 (15705)
bytes read:	10889124 (14636098)
bytes written:	0 (9352)
constructs:	73 (232)
destructs:	54 (179)
Access per table
    pre2            : 3438     pre2add         : 2655     precalcdata     : 1026     
    zimdat          : 837      lst             : 826      zim             : 679      
    blobdata        : 653      blobhead        : 652      txt             : 549      
    lstlink         : 240      gst             : 109      gpo             : 68       
    zbu             : 55       grp             : 54       res             : 50       
    rabatt          : 46       regpath         : 33       gko             : 24       
    regent          : 20       stka            : 14       ryth            : 3        
VALIDATION
Hits   : 10824 Records [10321654]
detailed info on hit records:
blobdata/105:652 blobhead/104:651 fgpo/23:48 grp/24:48 htxt/42:171 lst/28:825 lstlink/162:239 lsttxt/42:6 pre2/160:3437 pre2add/161:2654 precalcdata/236:1020 rabatt/117:45 regent/76:20 regpath/75:17 rgpo/23:3 ryth/79:3 stka/78:13 txt/42:336 zbu/47:55 zim/48:581
Misses : 0 Records [0]

STRINGS
15628771 strings constructed
12960215 strings destructed
2668556 strings active

10674224 strings memory

1998804 buffer allocations
1517326 buffer freed
 481478 buffers active

13827219 maximum StringHeap size
13795614 current StringHeap size
Number of current BO_SubjectBase objects  : 1819
Number of current BO_ObserverBase objects : 0
Next subject-id				  : 21373

# Before change
