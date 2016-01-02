INCLUDE MQOBJECT.FS
INCLUDE CONSTANTS.FS

\ MQTT PACKET STRUCTURE
\ HTTP://PUBLIC.DHE.IBM.COM/SOFTWARE/DW/WEBSERVICES/WS-MQTT/MQTT-V3R1.HTML#MSG-FORMAT

MQ:OBJECT CLASS MQ:FIXED-HEADER
    METHOD TO-BINARY

    METHOD MESSAGE-TYPE!
    METHOD MESSAGE-TYPE@
    METHOD DUP-FLAG!
    METHOD DUP-FLAG@
    METHOD QOS-LEVEL!
    METHOD QOS-LEVEL@
    METHOD QOS-RETAIN!
    METHOD QOS-RETAIN@
    METHOD QOS-LENGTH!
    METHOD QOS-LENGTH@


    1 CHARS VAR FLAGS
    1 CHARS VAR LENGTH

  HOW:

    : INIT ( N-MESSAGE-TYPE N-DUP-FLAG N-QOS-LEVEL N-RETAIN N-LENGTH -- SELF )
      .( I STOPPED HERE! ) ;

    : TO-BINARY ( SELF -- 2 CHARS )
      .( NOT YET IMPLEMENTED. ) ;
CLASS;

\ CREATE A NEW MQTT HEADER.
MQ:CONNECT MQ:AT-LEAST-ONCE MQ:NO-DUP 1 MQ:FIXED-HEADER : MY-HEADER

MY-HEADER AREA . CR

\ DESTROY THE SQUARE OBJECT (FOR EXAMPLE PURPOSES)
MY-HEADER DISPOSE
