using StrategyPattern;

Smartphone iphone = new Iphone();
Smartphone samsung = new SansungGalaxy();

iphone.StartUse();
toyota.StartUse();
iphone.SetUse(new IosUse());
toyota.SetUse(new AndroidUse());

iphone.StartUse();
toyota.StartUse();