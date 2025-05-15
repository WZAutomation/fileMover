#!/bin/bash
VERSIONNUM="VERSIONNUMBER"
TOREPLACE=`git rev-parse --short HEAD`
#echo $TOREPLACE
#echo $VERSIONNUM
sed -i "s/$TOREPLACE/$VERSIONNUM/g" AboutPopUp.Designer.cs