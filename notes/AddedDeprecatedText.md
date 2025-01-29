# Added deprecated text to:
- s_account_payment_add_v001.xml
- s_account_payment_add_v002.xml
- s_activity_search_v001.xml
- s_package_search_v001.xml

# Need deprecated text:
- s_account_service_add_v001.xml
- s_account_service_add_v002.xml
- s_account_service_with_manual_rate_add_v001.xml
- s_account_service_with_manual_rate_add_v002.xml
- s_go_config_v001.xml
- s_room_maintenance_state_get_v001.xml
- s_room_maintenance_state_get_v002.xml
- s_room_maintenance_state_mobile_get_v001.xml
- s_room_maintenance_state_without_image_get_v001.xml
- s_room_maintenance_state_without_image_get_v002.xml
- s_room_maintenance_state_without_image_mobile_get_v001.xml
- s_service_search_v001.xml
- s_reservation_complete_push_v009.xml

# Weird:
Estes services estao os dois no deprecated e no Activity folder. Na 04.01 nem existe o v003 e mesmo assim existe um v002 na pasta deprecated
- s_activity_get_v001.xml
- s_activity_get_v002.xml

Existe References em vez de deprecated: (Catia)
- s_rate_search_v001.xml
	<References>
		<Reference Service="S_RATE_SEARCH_V002" 	Text="Obtain a list of rates of combined services and categories"/>
	</References>

Sao notificacoes ou services? 
- s_tokenisation_notification_v01.xml
- s_tokenisation_notification_v02.xml
