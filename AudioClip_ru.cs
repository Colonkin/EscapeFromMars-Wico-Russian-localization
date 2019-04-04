using System.Collections.Generic;
using Duckroll;
using VRage.Game;

namespace EscapeFromMars
{
	internal class Speaker
	{
		internal static readonly Speaker Mabel = new Speaker("Mabel", MyFontEnum.Green);
		internal static readonly Speaker GCorp = new Speaker("GCorp Transmission", MyFontEnum.Red);
		internal static readonly Speaker Mech = new Speaker("Experimental Mech", MyFontEnum.Red);
		internal static readonly Speaker MrEd = new Speaker("MR.ED", MyFontEnum.Blue);
		internal static readonly Speaker Miki = new Speaker("Miki", MyFontEnum.White);
		internal static readonly Speaker None = new Speaker("None", MyFontEnum.BuildInfo);

		internal string Name { get; }
		internal MyFontEnum Font { get; }

		private Speaker(string name, MyFontEnum font)
		{
			Font = font;
			Name = name;
		}
	}

	public class AudioClip : IAudioClip
	{
		private static int _nextId = 1;
		private static readonly Dictionary<int, AudioClip> Index = new Dictionary<int, AudioClip>();

		internal static readonly AudioClip Cavern = Create("Cavern", EscapeFromMars.Speaker.None, "", 4000);

		internal static readonly AudioClip ConvoyArrivedSafely = Create("ConvoyArrivedSafely", EscapeFromMars.Speaker
		.GCorp,
			"*Muffled* Конвой прибыл благополучно", 4000);

		internal static readonly AudioClip ConvoyDispatched1 = Create("ConvoyDispatched1", EscapeFromMars.Speaker.GCorp,
			"*Muffled* Конвой отправлен", 7000);

		internal static readonly AudioClip ConvoyDispatched2 = Create("ConvoyDispatched2", EscapeFromMars.Speaker.GCorp,
			"*Muffled* Convoy dispatched", 7000);

		internal static readonly AudioClip ConvoyDispatched3 = Create("ConvoyDispatched3", EscapeFromMars.Speaker.GCorp,
			"*Muffled* Convoy dispatched", 6000);

		internal static readonly AudioClip ConvoyUnderThreat = Create("ConvoyUnderThreat", EscapeFromMars.Speaker.GCorp,
			"Конвой под угрозой! Возможная пиратская активность", 4000);

		internal static readonly AudioClip DisengagingFromHostile = Create("DisengagingFromHostile",
		EscapeFromMars.Speaker.GCorp,
			"Disengaging from hostile");

		internal static readonly AudioClip DroneDisarmed = Create("DroneDisarmed", EscapeFromMars.Speaker.GCorp, // USED
			"Дрон разоружен и возвращается на ремонт");

		internal static readonly AudioClip EnemyDetectedMovingToIntercept = Create("EnemyDetectedMovingToIntercept", // USED
			EscapeFromMars.Speaker.GCorp, "Враг обнаружен, двигаясь, чтобы перехватить");

		internal static readonly AudioClip FacilityDetectedHostile = Create("FacilityDetectedHostile",
			EscapeFromMars.Speaker.GCorp, "Сканеры объекта подобрали враждебные. Отправьте соседние патрули в " +
			                              "location",
			 6000);

		internal static readonly AudioClip GCorpBlockingSignals = Create("GCorpBlockingSignals",									// USED
			EscapeFromMars.Speaker.Mabel,
			@"Наш противник имеет полный контроль над марсианской поверхностью. Все первоначальные колонисты были удалены после их
приобретение эксклюзивных прав на добычу полезных ископаемых. G-Corp блокирует все сигналы с планеты, кроме их собственных.",
			13000);

		internal static readonly AudioClip GCorpFacilitiesHeavilyArmed = Create("GCorpFacilitiesHeavilyArmed",					// USED
			EscapeFromMars.Speaker.Mabel,
			@"Сканирование показывает, что объекты G-Corp в этом районе тщательно охраняются, приближаться к ним не рекомендуется.
если сильно не вооружен",
			8000);

		internal static readonly AudioClip GCorpFacilityThreatened = Create("GCorpFacilityThreatened",
		EscapeFromMars.Speaker.GCorp,
			// USED
			"Объект G-Corp подвергается угрое, отправляю дополнительные беспилотники");

		internal static readonly AudioClip GCorpTowerScan = Create("GCorpTowerScan", EscapeFromMars.Speaker.Mabel,


		// USED
			@"Я обнаруживаю необычные показания внутри башни штаб-квартиры G-Corp.
Это может быть способ покинуть планету, однако более безопасные варианты могут существовать [Эта область чрезвычайно опасна]",
			10000);

		internal static readonly AudioClip HostileDisappeared = Create("HostileDisappeared", EscapeFromMars.Speaker
		.GCorp,
		// USED
			"Враг исчез со сканеров. Возобновить патрулирование",
			5000);

		internal static readonly AudioClip HostileStillPresent = Create("HostileStillPresent", EscapeFromMars.Speaker
		.GCorp,
			"Враждебный по-прежнему присутствует. Запрашивать подкрепление немедленно",
			5000);

		internal static readonly AudioClip IntruderRobot = Create("IntruderRobot", EscapeFromMars.Speaker.Mech,
			"Нарушитель!",
			2000);

		internal static readonly AudioClip IntrudersMustBeDestroyedRobot = Create("IntrudersMustBeDestroyedRobot",
		EscapeFromMars.Speaker
		.Mech,
			"Злоумышленники должны быть уничтожены",
			3000);

		internal static readonly AudioClip LocatedIceMine = Create("LocatedIceMine", EscapeFromMars.Speaker.Mabel,
		// USED
			@"Сканирование на источник кислорода. Расположен GCorp контролируемый ледяной рудник
Загрузка координат в соответствии с HUD.", 7000);

		internal static readonly AudioClip MarsGCorpOperationsExplained = Create("MarsGCorpOperationsExplained",
		EscapeFromMars.Speaker
		.Mabel,	// USED
			@"Марс изобилует G-Corp объектов и операций. Они имеют эксклюзивный доступ к поверхности планеты, так как
колонисты были переселены. Магний, алюминий, титан, железо и хром составляют большую часть их экспорта.", 16000);

		internal static readonly AudioClip MilitaryPatrolInitiated = Create("MilitaryPatrolInitiated",
		EscapeFromMars.Speaker.GCorp,

		// USED
			"Начался военный патруль в поисках противника");

		internal static readonly AudioClip OldFreighterFound = Create("OldFreighterFound", EscapeFromMars.Speaker.Mabel,

		// USED
			@"Сканы показывают древний грузовик класса Игуана. Ни одна из его систем не активна.
Ремонт займет некоторое время, но это также может быть ваш единственный способ безопасно покинуть Марс", 11000);

		internal static readonly AudioClip OxygenGeneratorUnlocked = Create("OxygenGeneratorUnlocked",
		EscapeFromMars.Speaker.Mabel,
		// USED
			"Поиск файлов данных G-Corp. Технология генератора кислорода разблокирована!", 5000);

		internal static readonly AudioClip PowerUpClipped = Create("PowerUpClipped", EscapeFromMars.Speaker.None, "");

		internal static readonly AudioClip RingAroundMars = Create("RingAroundMars", EscapeFromMars.Speaker.Mabel,
		// USED
			@"По моим расчетам, через 27,6 миллиона лет Фобос будет разорван гравитационными силами,
приводя к созданию кольца вокруг Марса", 10000);

		internal static readonly AudioClip ShuttleDamageReport = Create("ShuttleDamage", EscapeFromMars.Speaker.Mabel,

		// USED
			@"Шаттл получил критический урон. Связь в автономном режиме.
Двигатели не найдены. Несколько дронов GCorp обнаружены поблизости",
			9000);

		internal static readonly AudioClip ShuttleDatabanks = Create("ShuttleDatabanks", EscapeFromMars.Speaker.Mabel,

			// USED
			@"Банки данных шаттла не содержат чертежей конструкции движителя, работающего на атмосфере или водороде.
Рекомендую исследовать компьютерное хранилище G-Corp",
			10000);

		internal static readonly AudioClip SuggestPiracy = Create("SuggestPiracy", EscapeFromMars.Speaker.Mabel,
			// USED
			@"Я рассчитал, что оптимальный способ получения ресурсов - перехват грузовых перевозок G-Corp.
Однако имейте в виду, что они могут повысить безопасность, если пропадает слишком много их грузов",
			12000);

		internal static readonly AudioClip TargetFleeingPursuit = Create("TargetFleeingPursuit", EscapeFromMars.Speaker
		.GCorp,	// USED
			"Цель убегает от преследования, дроны возвращаются на базу");

		internal static readonly AudioClip TargetFoundDronesAttack = Create("TargetFoundDronesAttack",
		EscapeFromMars.Speaker.GCorp,
			"Цель найдена, все дроны атакуют!");

		internal static readonly AudioClip TargetIdentifiedUnitsConverge = Create("TargetIdentifiedUnitsConverge",
		EscapeFromMars.Speaker
		.GCorp, // USED
			"Цель определена, все единицы сходятся!");

		internal static readonly AudioClip TargetLost = Create("TargetLost", EscapeFromMars.Speaker.GCorp, // USED
			"Цель потеряна, возврат к позициям");

		internal static readonly AudioClip TurretsAtTheMine = Create("TurretsAtTheMine", EscapeFromMars.Speaker.Mabel,
			"Обнаружение активных компьютеров вокруг шахты. Будьте осторожны с башенками безопасности G-Corp",
			6000);

		internal static readonly AudioClip UnknownHostileOnScanners = Create("UnknownHostileOnScanners",
		EscapeFromMars.Speaker.GCorp,
		// USED
			"Неизвестный враждебный обнаруживается на сканерах. привлекательно");

		internal static readonly AudioClip UnlockAtmospherics = Create("UnlockAtmospherics", EscapeFromMars.Speaker
		.Mabel, "Поиск файлов данных G-Corp. Атмосферные двигатели разблокированы!", 5000);

		internal static readonly AudioClip UnlockedMissiles = Create("UnlockedMissiles", EscapeFromMars.Speaker.Mabel,
			"Поиск файлов данных G-Corp. Ракетная технология разблокирована!", 5000);

		internal static readonly AudioClip OxygenFarmUnlocked = Create("OxygenFarmUnlocked", EscapeFromMars.Speaker
		.Mabel,
		// USED
				"Поиск файлов данных. Технология Кислородная Ферма разблокирована!", 5000);

		internal static readonly AudioClip DistressBeaconSilly = Create("DistressBeaconSilly", EscapeFromMars.Speaker
		.Mabel,
			// USED
			@"Я поднимаю сигнал бедствия корпорации поблизости. Быть осторожен. Это может быть ловушка или пираты. +
В любом случае, вы бы ужасно умерли.", 9000);

		internal static readonly AudioClip EscapedMars = Create("EscapedMars", EscapeFromMars.Speaker.Mabel, // USED
		    "Мы успешно избежали марсианской гравитации. Погоня не обнаружена.", 5000);

		internal static readonly AudioClip FlightResearchCenter = Create("FlightResearchCenter", EscapeFromMars.Speaker
		.Mabel, // USED
			@"Отчеты корпорации указывают на то, что на Марсе есть исследовательская станция с технологическими чертежами
может оказаться полезным. Загрузка координат в соответствии с HUD.", 9000);

		internal static readonly AudioClip OlympusMons = Create("OlympusMons", EscapeFromMars.Speaker.Mabel,	// USED
			@"Вы приближаетесь к Олимпу Монс, крупнейшему вулкану в Солнечной системе. Вулканы изначально помогли создать
атмосфера на Марсе, пока горячие точки, питающие их, не остыли.", 11000);

		internal static readonly AudioClip WeaponsResearchFacility = Create("WeaponsResearchFacility",
		EscapeFromMars.Speaker.Mabel,
			@"По транспортным путям корпорации по добыче данных я обнаружил, что там скрыта незаконная база для исследования оружия.
в этом месте. Загрузка в соответствии с HUD.", 9000);

		internal static readonly AudioClip GasStorageUnlocked = Create("GasStorageUnlocked", EscapeFromMars.Speaker
		.Mabel,
		//USED
			"Поиск файлов данных G-Corp. Технология хранения газа разблокирована.", 4000);

		internal static readonly AudioClip InterceptingTransmissions = Create("InterceptingTransmissions",
		EscapeFromMars.Speaker
		.Mabel,
		//USED
			@"Я перевел 18 процентов своей вычислительной мощности на перехват и декодирование передач G Corp.
Я передам их в ваш костюм, если они покажутся актуальными.", 9000);

		internal static readonly AudioClip ExplosivesNearby = Create("ExplosivesNearby", EscapeFromMars.Speaker.Mabel,
			"Я обнаружил взрывчатые вещества поблизости.", 3000);

		internal static readonly AudioClip PowerSignatureBehindWall = Create("PowerSignatureBehindWall",
		EscapeFromMars.Speaker.Mabel,
			"За одной из стен доносится энергетическая подпись.", 3000);

		internal static readonly AudioClip AllTechUnlocked = Create("AllTechUnlocked", EscapeFromMars.Speaker.Mabel,
		//USED
	        "Все технологии разблокированы.", 2000);

	    internal static readonly AudioClip EndCredits = Create("EndCredits", EscapeFromMars.Speaker.Mabel,    //USED
	        @"... Передача данных на всех частотах ...
[Сценарий завершен. Рекомендуется удалить EscapeFromMars Mod, если вы хотите продолжить играть]", 120000);

	    internal static readonly AudioClip NotifyOfSatellite = Create("NotifyOfSatellite", EscapeFromMars.Speaker.Mabel,

	    //USED
	        @"Я вычислил местоположение ближайшего геосинхронного спутника связи.
Если вам удастся покинуть планету, вы должны направить туда свой корабль, чтобы я мог передать
доказательства, которые мы собрали на корпорации для всех общественных каналов.", 14000);

		internal static readonly AudioClip FoundFilesOnNetwork = Create("FoundFilesOnNetwork", EscapeFromMars.Speaker
		.Mabel,
			@"Пока ты копался в базе, я обнаружил скрытые файлы в компьютерной сети.
Направление вывода на ближайший дисплей.", 8000);

		internal static readonly AudioClip IceMineFoundByAccident = Create("IceMineFoundByAccident",
		EscapeFromMars.Speaker
		.Mabel,
			"Вы нашли вышедшую из употребления корпорацию по добыче льда. Это будет ценным ресурсом для генерации кислорода.", 8000);

		internal static readonly AudioClip AccidentallyFoundFlightResearchCenter = Create
		("AccidentallyFoundFlightResearchCenter", EscapeFromMars.Speaker.Mabel,
			"Похоже, что это слегка защищенный исследовательский центр. Он может содержать ценные исследования для создания собственного летательного аппарата.", 7000);

		internal static readonly AudioClip WeaponsFacilityFoundByAccident = Create("WeaponsFacilityFoundByAccident",
		EscapeFromMars.Speaker.Mabel,
			"Этого хранилища нет ни на каких официальных картах. Я рекомендую тщательно исследовать это.", 6000);

		internal static readonly AudioClip OhDear = Create("OhDear", EscapeFromMars.Speaker.MrEd,
			@"О, дорогой, ты не должен быть здесь. Это собственность исследовательской экспедиции Марса.
Пожалуйста, покажите свой идентификационный значок или выйдите из здания.", 9000);

		internal static readonly AudioClip WelcomeBack = Create("WelcomeBack", EscapeFromMars.Speaker.MrEd,
			@"Добро пожаловать обратно анонимный повторный поисковик! Лифт готов принять вас вниз-вниз
в район эксперимента.", 8000);

		internal static readonly AudioClip ExperimentProgress = Create("ExperimentProgress", EscapeFromMars.Speaker.MrEd,
			@"Прогресс завершения эксперимента на ... 342 процента. Атмосфера - 95% азота, 3% кислорода,
1% аргона, следовые количества углекислого газа.", 13000);

		internal static readonly AudioClip ElevatorHere = Create("ElevatorHere", EscapeFromMars.Speaker.Mabel,
			"Чертежи показывают, что здесь должен быть лифт. Странный. Они должны быть устаревшими.", 6000);

		internal static readonly AudioClip ArmorVehicles = Create("ArmorVehicles", EscapeFromMars.Speaker.Mabel,
			@"Вы должны постараться собрать свои машины, подготовленные к бою. Для особо враждебных районов,
вы могли бы использовать дронов вместо того, чтобы рисковать собственной жизнью.", 9000);

		internal static readonly AudioClip FaintPowerSignature = Create("FaintPowerSignature", EscapeFromMars.Speaker
		.Mabel,
			"Я обнаружил слабую энергетическую сигнатуру...", 2000);

		internal static readonly AudioClip MreDefunded = Create("MreDefunded", EscapeFromMars.Speaker.Mabel,
			@"Экспедиция по исследованию Марса была отложена после того, как их проекты по терраформированию на Марсе провалились.
Тем не менее, они также управляли несколькими пунктами неотложной медицинской помощи по всей планете.
Некоторые из них все еще могут быть в рабочем состоянии.", 13000);

		internal static readonly AudioClip PursuitEvaded = Create("PursuitEvaded", EscapeFromMars.Speaker.GCorp,
			"Преследование уклонилось, возобновив стандартный курс и направление", 3000);

		internal static readonly AudioClip SensorsLostTrack = Create("SensorsLostTrack", EscapeFromMars.Speaker.GCorp,
			"Датчики потеряли след враждебного", 2000);

		internal static readonly AudioClip HackingSound = Create("HackingSound", EscapeFromMars.Speaker.None,	"",
		14000);

		internal static readonly AudioClip ConnectionLostSound = Create("ConnectionLostSound", EscapeFromMars.Speaker
		.None,
		"", 2000);

		internal static readonly AudioClip HackFinished = Create("HackFinished", EscapeFromMars.Speaker.None, "", 2000);

		internal static readonly AudioClip BestCustomer = Create("BestCustomer", EscapeFromMars.Speaker.Miki,
			@"Вы лучший клиент в течение всего года! ... Единственный клиент в течение всего года.", 6000);

		internal static readonly AudioClip DontBreatheIn = Create("DontBreatheIn", EscapeFromMars.Speaker.Miki,
			"Лучше не ... вдыхать пары, когда мы плавим это.", 4000);

		internal static readonly AudioClip GreetingsMartianColonists = Create("GreetingsMartianColonists",
		EscapeFromMars.Speaker.Miki,
			@"Приветствую Марсианского Колониста! Miki Scrap теперь открыт для всех нужд переработки.
У вас есть старье, металлолом? Мы даем новые, лучшие вещи взамен.
Просто следуйте сигналу антенны!", 16000);

		internal static readonly AudioClip LavaLoop = Create("LavaLoop", EscapeFromMars.Speaker.None,
			"[Bubbling furnace sounds]", 75000);

		internal static readonly AudioClip NewMikiScrapsOpen = Create("NewMikiScrapsOpen", EscapeFromMars.Speaker.Miki,
			"New Miki Scraps открыт все время! Ищите нас на других планетах ... или мы приходим искать вас.", 8000);

		internal static readonly AudioClip PartOfBuilding = Create("PartOfBuilding", EscapeFromMars.Speaker.Miki,
			"Что это, часть здания !? Убери это отсюда!", 4000);

		internal static readonly AudioClip TellAllFriends = Create("TellAllFriends", EscapeFromMars.Speaker.Miki,
			"Помните, расскажите всем друзьям-колонистам о Miki Scrap!", 4000);

		internal static readonly AudioClip ThisIsGoodScrap = Create("ThisIsGoodScrap", EscapeFromMars.Speaker.Miki,
			"Это хороший лом! Мы таем за тебя", 4000);

		internal static readonly AudioClip TiredOfGrindingCrap = Create("TiredOfGrindingCrap", EscapeFromMars.Speaker
		.Miki,
			"Устали от утилизировать отходы? Мы можем это сделать! Miki Scrap.", 4000);

		internal static readonly AudioClip WeCrushDown = Create("WeCrushDown", EscapeFromMars.Speaker.Miki,
			"Мы раздавим маленькие кубики для вас!", 3000);

		internal static readonly AudioClip WelcomeMikiScrap = Create("WelcomeMikiScrap", EscapeFromMars.Speaker.Miki,
			"Добро пожаловать в Miki Scrap!", 2000);

		internal static readonly AudioClip WhereDoYouGetScrapMetal = Create("WhereDoYouGetScrapMetal",
		EscapeFromMars.Speaker.Miki,
			"Где вы берете весь этот металлолом? Я никогда не видел так много!", 5000);

		internal static readonly AudioClip WhereIsThatFrom = Create("WhereIsThatFrom", EscapeFromMars.Speaker.Miki,
			"Откуда это? Не берите в голову! Мы заставляем исчезнуть для вас.", 6000);

	    private static AudioClip Create(string subTypeName, Speaker speaker, string subtitle, int disappearTimeMs = 4200)
		{
			var id = _nextId++;
			var clip = new AudioClip(id, subTypeName, speaker, subtitle, disappearTimeMs);
			Index.Add(id, clip);
			return clip;
		}

		public static AudioClip GetClipFromId(int id)
		{
			return Index[id];
		}

		public string Filename { get; }
		public string Subtitle { get; }
		public string Speaker { get; }
		public MyFontEnum Font { get; }
		public int DisappearTimeMs { get; }
		public int Id { get; }

		private AudioClip(int id, string filename, Speaker speaker, string subtitle, int disappearTimeMs)
		{
			Id = id;
			DisappearTimeMs = disappearTimeMs;
			Speaker = speaker.Name;
			Font = speaker.Font;
			Filename = filename;
			Subtitle = subtitle;
		}
	}
}
