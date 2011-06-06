
#include "VirtualTests.h"

NumberClass::NumberClass (int n)
	: num (n)
{
}
int NumberClass::Number () const
{
	return this->num;
}
int NumberClass::NegativeNumber () const
{
	return -(this->num);
}


AdderClass::AdderClass (int n)
	: NumberClass (n)
{
}
void AdderClass::Add (int n)
{
	this->num += n;
}

AdderClassWithVirtualBase::AdderClassWithVirtualBase (int n)
	: NumberClass (n)
{
}
void AdderClassWithVirtualBase::Add (int n)
{
	this->num += n;
}


MultiplierClass::MultiplierClass (int n)
	: NumberClass (n)
{
}
void MultiplierClass::Multiply (int n)
{
	this->num *= n;
}

MultiplierClassWithVirtualBase::MultiplierClassWithVirtualBase (int n)
	: NumberClass (n)
{
}
void MultiplierClassWithVirtualBase::Multiply (int n)
{
	this->num *= n;
}


ClassThatOverridesStuff::ClassThatOverridesStuff (int num, int my)
	: NumberClass (num), myNum (my)
{
}
int ClassThatOverridesStuff::Number () const
{
	return this->myNum;
}