using StrategyPattern;

Smartphone iphone = new Iphone();
Smartphone samsung = new SamsungGalaxy();

iphone.StartUse();
samsung.StartUse();
iphone.SetUse(new IosUse());
samsung.SetUse(new AndroidUse());

iphone.StartUse();
samsung.StartUse();