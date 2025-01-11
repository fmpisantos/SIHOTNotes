BO_Res:
    - Registry BO_Res->enableExactNameListStateAnalyse
	- BO_NamelistGroup:
	    - !m_zbu.objID.valid() && guid.isValid() && !T::isHQSyncServer()
    - else
	- !T::isHQSyncServer
	- res.objID.valid()
	- res.anzPersonenCheckOut != res.anzPersonen
	- (res.anzZimmerZugeordnet + res.anzZimmerCheckIn + res.anzZimmerCheckOut) != res.anzZimmer
