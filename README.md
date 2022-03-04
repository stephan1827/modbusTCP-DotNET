# Introduction
Visual Studio modbusTCP class

This class implements a Modbus TCP master driver. The code is written in C# but the DLL can 
be used in any other language. 

![Picture](https://github.com/stephanstricker/modbusTCP/blob/master/Screenshot.png)

## It supports the following function codes:

* Read coils
* Read discrete inputs
* Write single coil
* Write multiple coils
* Read holding register
* Read input register
* Write single register
* Write multiple registers

Background
I will not explain how the Modbus protocol works in detail because there is plenty of information available online.

[Modbus IDA home page](http://www.modbus.org/)

[Modbus IDA PDF documentation](http://www.modbus.org/docs/Modbus_Messaging_Implementation_Guide_V1_0a.pdf)

## Using the code
All commands are sent in synchronous or asynchronous mode. If a value is accessed in synchronous mode, the program will stop and wait for the slave to respond. If the slave does not answer within a specified time, a timeout exception is called. The class uses multi-threading for both synchronous and asynchronous access. The class opens two communication channels for each slave. This is necessary because the synchronous thread has to wait for a command to finish. This would block the asynchronous connection. The class directory contains a help file (ModbusClassTCP\doc) with detailed information for every function.

A sample application is included in the package that shows the basic features. It uses asynchronous mode for all function calls. The sample has some additional code to make the result handling more comfortable.

## Points of Interest
Remember that a lot of Modbus clients use a watchdog telegram to make sure the master is still active. If you don’t call this watchdog within a specified time, the slave will close the connection. This feature is used to avoid unused open ports when the connection is interrupted.

## History
Next Version (04/03/2022)
- Fixed: Typo in sample 

Version 3.6 (26/03/2019)
- Fixed: Handle null reference in receive function block when cable is disconnected

Version 3.5 (12/06/2018)
- Fixed: Exception is not triggered when synchonous channel is disabled
- Fixed: WriteSingleRegister now fires exception excIllegalDataVal if number of bytes is not 2

Version 3.4 (01/01/2015)
- Added: Option to disable synchronous channel to limit number of connections to one
- Added: Trigger exception if number of registers (250) or discrete values (2000) is exceeded

Version 3.3 (6/14/2013)

- Fixed: ID high and low byte swapped
- Added: Modbus parameter UNIT added to function calls

Version 3.2

First release
Edit message

Write a small message here explaining this change. (Optional)
© 2018 GitHub, Inc.
Terms
Privacy
Security
Status
Help
Contact GitHub
API
Training
Shop
Blog
About
Press h to open a hovercard with more details.
