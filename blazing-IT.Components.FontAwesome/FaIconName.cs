using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace blazing_IT.Components.FontAwesome
{
    /// <summary>
    /// All FontAwesome icon classes as enum
    /// </summary>
    /// <remarks>
    /// Full list of icons with examples: 
    /// https://fontawesome.com/icons?d=gallery
    /// </remarks>
    public enum FaIconName
    {
        [CssClass("fa-500px")]
        _500px,

        [CssClass("fa-abacus")]
        Abacus,

        [CssClass("fa-accessible-icon")]
        AccessibleIcon,

        [CssClass("fa-accusoft")]
        Accusoft,

        [CssClass("fa-acorn")]
        Acorn,

        [CssClass("fa-acquisitions-incorporated")]
        AcquisitionsIncorporated,

        [CssClass("fa-ad")]
        Ad,

        [CssClass("fa-address-book")]
        AddressBook,

        [CssClass("fa-address-card")]
        AddressCard,

        [CssClass("fa-adjust")]
        Adjust,

        [CssClass("fa-adn")]
        Adn,

        [CssClass("fa-adversal")]
        Adversal,

        [CssClass("fa-affiliatetheme")]
        Affiliatetheme,

        [CssClass("fa-air-conditioner")]
        AirConditioner,

        [CssClass("fa-air-freshener")]
        AirFreshener,

        [CssClass("fa-airbnb")]
        Airbnb,

        [CssClass("fa-alarm-clock")]
        AlarmClock,

        [CssClass("fa-alarm-exclamation")]
        AlarmExclamation,

        [CssClass("fa-alarm-plus")]
        AlarmPlus,

        [CssClass("fa-alarm-snooze")]
        AlarmSnooze,

        [CssClass("fa-album")]
        Album,

        [CssClass("fa-album-collection")]
        AlbumCollection,

        [CssClass("fa-algolia")]
        Algolia,

        [CssClass("fa-alicorn")]
        Alicorn,

        [CssClass("fa-alien")]
        Alien,

        [CssClass("fa-alien-monster")]
        AlienMonster,

        [CssClass("fa-align-center")]
        AlignCenter,

        [CssClass("fa-align-justify")]
        AlignJustify,

        [CssClass("fa-align-left")]
        AlignLeft,

        [CssClass("fa-align-right")]
        AlignRight,

        [CssClass("fa-align-slash")]
        AlignSlash,

        [CssClass("fa-alipay")]
        Alipay,

        [CssClass("fa-allergies")]
        Allergies,

        [CssClass("fa-amazon")]
        Amazon,

        [CssClass("fa-amazon-pay")]
        AmazonPay,

        [CssClass("fa-ambulance")]
        Ambulance,

        [CssClass("fa-american-sign-language-interpreting")]
        AmericanSignLanguageInterpreting,

        [CssClass("fa-amilia")]
        Amilia,

        [CssClass("fa-amp-guitar")]
        AmpGuitar,

        [CssClass("fa-analytics")]
        Analytics,

        [CssClass("fa-anchor")]
        Anchor,

        [CssClass("fa-android")]
        Android,

        [CssClass("fa-angel")]
        Angel,

        [CssClass("fa-angellist")]
        Angellist,

        [CssClass("fa-angle-double-down")]
        AngleDoubleDown,

        [CssClass("fa-angle-double-left")]
        AngleDoubleLeft,

        [CssClass("fa-angle-double-right")]
        AngleDoubleRight,

        [CssClass("fa-angle-double-up")]
        AngleDoubleUp,

        [CssClass("fa-angle-down")]
        AngleDown,

        [CssClass("fa-angle-left")]
        AngleLeft,

        [CssClass("fa-angle-right")]
        AngleRight,

        [CssClass("fa-angle-up")]
        AngleUp,

        [CssClass("fa-angry")]
        Angry,

        [CssClass("fa-angrycreative")]
        Angrycreative,

        [CssClass("fa-angular")]
        Angular,

        [CssClass("fa-ankh")]
        Ankh,

        [CssClass("fa-app-store")]
        AppStore,

        [CssClass("fa-app-store-ios")]
        AppStoreIos,

        [CssClass("fa-apper")]
        Apper,

        [CssClass("fa-apple")]
        Apple,

        [CssClass("fa-apple-alt")]
        AppleAlt,

        [CssClass("fa-apple-crate")]
        AppleCrate,

        [CssClass("fa-apple-pay")]
        ApplePay,

        [CssClass("fa-archive")]
        Archive,

        [CssClass("fa-archway")]
        Archway,

        [CssClass("fa-arrow-alt-circle-down")]
        ArrowAltCircleDown,

        [CssClass("fa-arrow-alt-circle-left")]
        ArrowAltCircleLeft,

        [CssClass("fa-arrow-alt-circle-right")]
        ArrowAltCircleRight,

        [CssClass("fa-arrow-alt-circle-up")]
        ArrowAltCircleUp,

        [CssClass("fa-arrow-alt-down")]
        ArrowAltDown,

        [CssClass("fa-arrow-alt-from-bottom")]
        ArrowAltFromBottom,

        [CssClass("fa-arrow-alt-from-left")]
        ArrowAltFromLeft,

        [CssClass("fa-arrow-alt-from-right")]
        ArrowAltFromRight,

        [CssClass("fa-arrow-alt-from-top")]
        ArrowAltFromTop,

        [CssClass("fa-arrow-alt-left")]
        ArrowAltLeft,

        [CssClass("fa-arrow-alt-right")]
        ArrowAltRight,

        [CssClass("fa-arrow-alt-square-down")]
        ArrowAltSquareDown,

        [CssClass("fa-arrow-alt-square-left")]
        ArrowAltSquareLeft,

        [CssClass("fa-arrow-alt-square-right")]
        ArrowAltSquareRight,

        [CssClass("fa-arrow-alt-square-up")]
        ArrowAltSquareUp,

        [CssClass("fa-arrow-alt-to-bottom")]
        ArrowAltToBottom,

        [CssClass("fa-arrow-alt-to-left")]
        ArrowAltToLeft,

        [CssClass("fa-arrow-alt-to-right")]
        ArrowAltToRight,

        [CssClass("fa-arrow-alt-to-top")]
        ArrowAltToTop,

        [CssClass("fa-arrow-alt-up")]
        ArrowAltUp,

        [CssClass("fa-arrow-circle-down")]
        ArrowCircleDown,

        [CssClass("fa-arrow-circle-left")]
        ArrowCircleLeft,

        [CssClass("fa-arrow-circle-right")]
        ArrowCircleRight,

        [CssClass("fa-arrow-circle-up")]
        ArrowCircleUp,

        [CssClass("fa-arrow-down")]
        ArrowDown,

        [CssClass("fa-arrow-from-bottom")]
        ArrowFromBottom,

        [CssClass("fa-arrow-from-left")]
        ArrowFromLeft,

        [CssClass("fa-arrow-from-right")]
        ArrowFromRight,

        [CssClass("fa-arrow-from-top")]
        ArrowFromTop,

        [CssClass("fa-arrow-left")]
        ArrowLeft,

        [CssClass("fa-arrow-right")]
        ArrowRight,

        [CssClass("fa-arrow-square-down")]
        ArrowSquareDown,

        [CssClass("fa-arrow-square-left")]
        ArrowSquareLeft,

        [CssClass("fa-arrow-square-right")]
        ArrowSquareRight,

        [CssClass("fa-arrow-square-up")]
        ArrowSquareUp,

        [CssClass("fa-arrow-to-bottom")]
        ArrowToBottom,

        [CssClass("fa-arrow-to-left")]
        ArrowToLeft,

        [CssClass("fa-arrow-to-right")]
        ArrowToRight,

        [CssClass("fa-arrow-to-top")]
        ArrowToTop,

        [CssClass("fa-arrow-up")]
        ArrowUp,

        [CssClass("fa-arrows")]
        Arrows,

        [CssClass("fa-arrows-alt")]
        ArrowsAlt,

        [CssClass("fa-arrows-alt-h")]
        ArrowsAltH,

        [CssClass("fa-arrows-alt-v")]
        ArrowsAltV,

        [CssClass("fa-arrows-h")]
        ArrowsH,

        [CssClass("fa-arrows-v")]
        ArrowsV,

        [CssClass("fa-artstation")]
        Artstation,

        [CssClass("fa-assistive-listening-systems")]
        AssistiveListeningSystems,

        [CssClass("fa-asterisk")]
        Asterisk,

        [CssClass("fa-asymmetrik")]
        Asymmetrik,

        [CssClass("fa-at")]
        At,

        [CssClass("fa-atlas")]
        Atlas,

        [CssClass("fa-atlassian")]
        Atlassian,

        [CssClass("fa-atom")]
        Atom,

        [CssClass("fa-atom-alt")]
        AtomAlt,

        [CssClass("fa-audible")]
        Audible,

        [CssClass("fa-audio-description")]
        AudioDescription,

        [CssClass("fa-autoprefixer")]
        Autoprefixer,

        [CssClass("fa-avianex")]
        Avianex,

        [CssClass("fa-aviato")]
        Aviato,

        [CssClass("fa-award")]
        Award,

        [CssClass("fa-aws")]
        Aws,

        [CssClass("fa-axe")]
        Axe,

        [CssClass("fa-axe-battle")]
        AxeBattle,

        [CssClass("fa-baby")]
        Baby,

        [CssClass("fa-baby-carriage")]
        BabyCarriage,

        [CssClass("fa-backpack")]
        Backpack,

        [CssClass("fa-backspace")]
        Backspace,

        [CssClass("fa-backward")]
        Backward,

        [CssClass("fa-bacon")]
        Bacon,

        [CssClass("fa-bacteria")]
        Bacteria,

        [CssClass("fa-bacterium")]
        Bacterium,

        [CssClass("fa-badge")]
        Badge,

        [CssClass("fa-badge-check")]
        BadgeCheck,

        [CssClass("fa-badge-dollar")]
        BadgeDollar,

        [CssClass("fa-badge-percent")]
        BadgePercent,

        [CssClass("fa-badge-sheriff")]
        BadgeSheriff,

        [CssClass("fa-badger-honey")]
        BadgerHoney,

        [CssClass("fa-bags-shopping")]
        BagsShopping,

        [CssClass("fa-bahai")]
        Bahai,

        [CssClass("fa-balance-scale")]
        BalanceScale,

        [CssClass("fa-balance-scale-left")]
        BalanceScaleLeft,

        [CssClass("fa-balance-scale-right")]
        BalanceScaleRight,

        [CssClass("fa-ball-pile")]
        BallPile,

        [CssClass("fa-ballot")]
        Ballot,

        [CssClass("fa-ballot-check")]
        BallotCheck,

        [CssClass("fa-ban")]
        Ban,

        [CssClass("fa-band-aid")]
        BandAid,

        [CssClass("fa-bandcamp")]
        Bandcamp,

        [CssClass("fa-banjo")]
        Banjo,

        [CssClass("fa-barcode")]
        Barcode,

        [CssClass("fa-barcode-alt")]
        BarcodeAlt,

        [CssClass("fa-barcode-read")]
        BarcodeRead,

        [CssClass("fa-barcode-scan")]
        BarcodeScan,

        [CssClass("fa-bars")]
        Bars,

        [CssClass("fa-baseball")]
        Baseball,

        [CssClass("fa-baseball-ball")]
        BaseballBall,

        [CssClass("fa-basketball-ball")]
        BasketballBall,

        [CssClass("fa-basketball-hoop")]
        BasketballHoop,

        [CssClass("fa-bat")]
        Bat,

        [CssClass("fa-bath")]
        Bath,

        [CssClass("fa-battery-bolt")]
        BatteryBolt,

        [CssClass("fa-battery-empty")]
        BatteryEmpty,

        [CssClass("fa-battery-full")]
        BatteryFull,

        [CssClass("fa-battery-half")]
        BatteryHalf,

        [CssClass("fa-battery-quarter")]
        BatteryQuarter,

        [CssClass("fa-battery-slash")]
        BatterySlash,

        [CssClass("fa-battery-three-quarters")]
        BatteryThreeQuarters,

        [CssClass("fa-battle-net")]
        BattleNet,

        [CssClass("fa-bed")]
        Bed,

        [CssClass("fa-bed-alt")]
        BedAlt,

        [CssClass("fa-bed-bunk")]
        BedBunk,

        [CssClass("fa-bed-empty")]
        BedEmpty,

        [CssClass("fa-beer")]
        Beer,

        [CssClass("fa-behance")]
        Behance,

        [CssClass("fa-behance-square")]
        BehanceSquare,

        [CssClass("fa-bell")]
        Bell,

        [CssClass("fa-bell-exclamation")]
        BellExclamation,

        [CssClass("fa-bell-on")]
        BellOn,

        [CssClass("fa-bell-plus")]
        BellPlus,

        [CssClass("fa-bell-school")]
        BellSchool,

        [CssClass("fa-bell-school-slash")]
        BellSchoolSlash,

        [CssClass("fa-bell-slash")]
        BellSlash,

        [CssClass("fa-bells")]
        Bells,

        [CssClass("fa-betamax")]
        Betamax,

        [CssClass("fa-bezier-curve")]
        BezierCurve,

        [CssClass("fa-bible")]
        Bible,

        [CssClass("fa-bicycle")]
        Bicycle,

        [CssClass("fa-biking")]
        Biking,

        [CssClass("fa-biking-mountain")]
        BikingMountain,

        [CssClass("fa-bimobject")]
        Bimobject,

        [CssClass("fa-binoculars")]
        Binoculars,

        [CssClass("fa-biohazard")]
        Biohazard,

        [CssClass("fa-birthday-cake")]
        BirthdayCake,

        [CssClass("fa-bitbucket")]
        Bitbucket,

        [CssClass("fa-bitcoin")]
        Bitcoin,

        [CssClass("fa-bity")]
        Bity,

        [CssClass("fa-black-tie")]
        BlackTie,

        [CssClass("fa-blackberry")]
        Blackberry,

        [CssClass("fa-blanket")]
        Blanket,

        [CssClass("fa-blender")]
        Blender,

        [CssClass("fa-blender-phone")]
        BlenderPhone,

        [CssClass("fa-blind")]
        Blind,

        [CssClass("fa-blinds")]
        Blinds,

        [CssClass("fa-blinds-open")]
        BlindsOpen,

        [CssClass("fa-blinds-raised")]
        BlindsRaised,

        [CssClass("fa-blog")]
        Blog,

        [CssClass("fa-blogger")]
        Blogger,

        [CssClass("fa-blogger-b")]
        BloggerB,

        [CssClass("fa-bluetooth")]
        Bluetooth,

        [CssClass("fa-bluetooth-b")]
        BluetoothB,

        [CssClass("fa-bold")]
        Bold,

        [CssClass("fa-bolt")]
        Bolt,

        [CssClass("fa-bomb")]
        Bomb,

        [CssClass("fa-bone")]
        Bone,

        [CssClass("fa-bone-break")]
        BoneBreak,

        [CssClass("fa-bong")]
        Bong,

        [CssClass("fa-book")]
        Book,

        [CssClass("fa-book-alt")]
        BookAlt,

        [CssClass("fa-book-dead")]
        BookDead,

        [CssClass("fa-book-heart")]
        BookHeart,

        [CssClass("fa-book-medical")]
        BookMedical,

        [CssClass("fa-book-open")]
        BookOpen,

        [CssClass("fa-book-reader")]
        BookReader,

        [CssClass("fa-book-spells")]
        BookSpells,

        [CssClass("fa-book-user")]
        BookUser,

        [CssClass("fa-bookmark")]
        Bookmark,

        [CssClass("fa-books")]
        Books,

        [CssClass("fa-books-medical")]
        BooksMedical,

        [CssClass("fa-boombox")]
        Boombox,

        [CssClass("fa-boot")]
        Boot,

        [CssClass("fa-booth-curtain")]
        BoothCurtain,

        [CssClass("fa-bootstrap")]
        Bootstrap,

        [CssClass("fa-border-all")]
        BorderAll,

        [CssClass("fa-border-bottom")]
        BorderBottom,

        [CssClass("fa-border-center-h")]
        BorderCenterH,

        [CssClass("fa-border-center-v")]
        BorderCenterV,

        [CssClass("fa-border-inner")]
        BorderInner,

        [CssClass("fa-border-left")]
        BorderLeft,

        [CssClass("fa-border-none")]
        BorderNone,

        [CssClass("fa-border-outer")]
        BorderOuter,

        [CssClass("fa-border-right")]
        BorderRight,

        [CssClass("fa-border-style")]
        BorderStyle,

        [CssClass("fa-border-style-alt")]
        BorderStyleAlt,

        [CssClass("fa-border-top")]
        BorderTop,

        [CssClass("fa-bow-arrow")]
        BowArrow,

        [CssClass("fa-bowling-ball")]
        BowlingBall,

        [CssClass("fa-bowling-pins")]
        BowlingPins,

        [CssClass("fa-box")]
        Box,

        [CssClass("fa-box-alt")]
        BoxAlt,

        [CssClass("fa-box-ballot")]
        BoxBallot,

        [CssClass("fa-box-check")]
        BoxCheck,

        [CssClass("fa-box-fragile")]
        BoxFragile,

        [CssClass("fa-box-full")]
        BoxFull,

        [CssClass("fa-box-heart")]
        BoxHeart,

        [CssClass("fa-box-open")]
        BoxOpen,

        [CssClass("fa-box-tissue")]
        BoxTissue,

        [CssClass("fa-box-up")]
        BoxUp,

        [CssClass("fa-box-usd")]
        BoxUsd,

        [CssClass("fa-boxes")]
        Boxes,

        [CssClass("fa-boxes-alt")]
        BoxesAlt,

        [CssClass("fa-boxing-glove")]
        BoxingGlove,

        [CssClass("fa-brackets")]
        Brackets,

        [CssClass("fa-brackets-curly")]
        BracketsCurly,

        [CssClass("fa-braille")]
        Braille,

        [CssClass("fa-brain")]
        Brain,

        [CssClass("fa-bread-loaf")]
        BreadLoaf,

        [CssClass("fa-bread-slice")]
        BreadSlice,

        [CssClass("fa-briefcase")]
        Briefcase,

        [CssClass("fa-briefcase-medical")]
        BriefcaseMedical,

        [CssClass("fa-bring-forward")]
        BringForward,

        [CssClass("fa-bring-front")]
        BringFront,

        [CssClass("fa-broadcast-tower")]
        BroadcastTower,

        [CssClass("fa-broom")]
        Broom,

        [CssClass("fa-browser")]
        Browser,

        [CssClass("fa-brush")]
        Brush,

        [CssClass("fa-btc")]
        Btc,

        [CssClass("fa-buffer")]
        Buffer,

        [CssClass("fa-bug")]
        Bug,

        [CssClass("fa-building")]
        Building,

        [CssClass("fa-bullhorn")]
        Bullhorn,

        [CssClass("fa-bullseye")]
        Bullseye,

        [CssClass("fa-bullseye-arrow")]
        BullseyeArrow,

        [CssClass("fa-bullseye-pointer")]
        BullseyePointer,

        [CssClass("fa-burger-soda")]
        BurgerSoda,

        [CssClass("fa-burn")]
        Burn,

        [CssClass("fa-buromobelexperte")]
        Buromobelexperte,

        [CssClass("fa-burrito")]
        Burrito,

        [CssClass("fa-bus")]
        Bus,

        [CssClass("fa-bus-alt")]
        BusAlt,

        [CssClass("fa-bus-school")]
        BusSchool,

        [CssClass("fa-business-time")]
        BusinessTime,

        [CssClass("fa-buy-n-large")]
        BuyNLarge,

        [CssClass("fa-buysellads")]
        Buysellads,

        [CssClass("fa-cabinet-filing")]
        CabinetFiling,

        [CssClass("fa-cactus")]
        Cactus,

        [CssClass("fa-calculator")]
        Calculator,

        [CssClass("fa-calculator-alt")]
        CalculatorAlt,

        [CssClass("fa-calendar")]
        Calendar,

        [CssClass("fa-calendar-alt")]
        CalendarAlt,

        [CssClass("fa-calendar-check")]
        CalendarCheck,

        [CssClass("fa-calendar-day")]
        CalendarDay,

        [CssClass("fa-calendar-edit")]
        CalendarEdit,

        [CssClass("fa-calendar-exclamation")]
        CalendarExclamation,

        [CssClass("fa-calendar-minus")]
        CalendarMinus,

        [CssClass("fa-calendar-plus")]
        CalendarPlus,

        [CssClass("fa-calendar-star")]
        CalendarStar,

        [CssClass("fa-calendar-times")]
        CalendarTimes,

        [CssClass("fa-calendar-week")]
        CalendarWeek,

        [CssClass("fa-camcorder")]
        Camcorder,

        [CssClass("fa-camera")]
        Camera,

        [CssClass("fa-camera-alt")]
        CameraAlt,

        [CssClass("fa-camera-home")]
        CameraHome,

        [CssClass("fa-camera-movie")]
        CameraMovie,

        [CssClass("fa-camera-polaroid")]
        CameraPolaroid,

        [CssClass("fa-camera-retro")]
        CameraRetro,

        [CssClass("fa-campfire")]
        Campfire,

        [CssClass("fa-campground")]
        Campground,

        [CssClass("fa-canadian-maple-leaf")]
        CanadianMapleLeaf,

        [CssClass("fa-candle-holder")]
        CandleHolder,

        [CssClass("fa-candy-cane")]
        CandyCane,

        [CssClass("fa-candy-corn")]
        CandyCorn,

        [CssClass("fa-cannabis")]
        Cannabis,

        [CssClass("fa-capsules")]
        Capsules,

        [CssClass("fa-car")]
        Car,

        [CssClass("fa-car-alt")]
        CarAlt,

        [CssClass("fa-car-battery")]
        CarBattery,

        [CssClass("fa-car-building")]
        CarBuilding,

        [CssClass("fa-car-bump")]
        CarBump,

        [CssClass("fa-car-bus")]
        CarBus,

        [CssClass("fa-car-crash")]
        CarCrash,

        [CssClass("fa-car-garage")]
        CarGarage,

        [CssClass("fa-car-mechanic")]
        CarMechanic,

        [CssClass("fa-car-side")]
        CarSide,

        [CssClass("fa-car-tilt")]
        CarTilt,

        [CssClass("fa-car-wash")]
        CarWash,

        [CssClass("fa-caravan")]
        Caravan,

        [CssClass("fa-caravan-alt")]
        CaravanAlt,

        [CssClass("fa-caret-circle-down")]
        CaretCircleDown,

        [CssClass("fa-caret-circle-left")]
        CaretCircleLeft,

        [CssClass("fa-caret-circle-right")]
        CaretCircleRight,

        [CssClass("fa-caret-circle-up")]
        CaretCircleUp,

        [CssClass("fa-caret-down")]
        CaretDown,

        [CssClass("fa-caret-left")]
        CaretLeft,

        [CssClass("fa-caret-right")]
        CaretRight,

        [CssClass("fa-caret-square-down")]
        CaretSquareDown,

        [CssClass("fa-caret-square-left")]
        CaretSquareLeft,

        [CssClass("fa-caret-square-right")]
        CaretSquareRight,

        [CssClass("fa-caret-square-up")]
        CaretSquareUp,

        [CssClass("fa-caret-up")]
        CaretUp,

        [CssClass("fa-carrot")]
        Carrot,

        [CssClass("fa-cars")]
        Cars,

        [CssClass("fa-cart-arrow-down")]
        CartArrowDown,

        [CssClass("fa-cart-plus")]
        CartPlus,

        [CssClass("fa-cash-register")]
        CashRegister,

        [CssClass("fa-cassette-tape")]
        CassetteTape,

        [CssClass("fa-cat")]
        Cat,

        [CssClass("fa-cat-space")]
        CatSpace,

        [CssClass("fa-cauldron")]
        Cauldron,

        [CssClass("fa-cc-amazon-pay")]
        CcAmazonPay,

        [CssClass("fa-cc-amex")]
        CcAmex,

        [CssClass("fa-cc-apple-pay")]
        CcApplePay,

        [CssClass("fa-cc-diners-club")]
        CcDinersClub,

        [CssClass("fa-cc-discover")]
        CcDiscover,

        [CssClass("fa-cc-jcb")]
        CcJcb,

        [CssClass("fa-cc-mastercard")]
        CcMastercard,

        [CssClass("fa-cc-paypal")]
        CcPaypal,

        [CssClass("fa-cc-stripe")]
        CcStripe,

        [CssClass("fa-cc-visa")]
        CcVisa,

        [CssClass("fa-cctv")]
        Cctv,

        [CssClass("fa-centercode")]
        Centercode,

        [CssClass("fa-centos")]
        Centos,

        [CssClass("fa-certificate")]
        Certificate,

        [CssClass("fa-chair")]
        Chair,

        [CssClass("fa-chair-office")]
        ChairOffice,

        [CssClass("fa-chalkboard")]
        Chalkboard,

        [CssClass("fa-chalkboard-teacher")]
        ChalkboardTeacher,

        [CssClass("fa-charging-station")]
        ChargingStation,

        [CssClass("fa-chart-area")]
        ChartArea,

        [CssClass("fa-chart-bar")]
        ChartBar,

        [CssClass("fa-chart-line")]
        ChartLine,

        [CssClass("fa-chart-line-down")]
        ChartLineDown,

        [CssClass("fa-chart-network")]
        ChartNetwork,

        [CssClass("fa-chart-pie")]
        ChartPie,

        [CssClass("fa-chart-pie-alt")]
        ChartPieAlt,

        [CssClass("fa-chart-scatter")]
        ChartScatter,

        [CssClass("fa-check")]
        Check,

        [CssClass("fa-check-circle")]
        CheckCircle,

        [CssClass("fa-check-double")]
        CheckDouble,

        [CssClass("fa-check-square")]
        CheckSquare,

        [CssClass("fa-cheese")]
        Cheese,

        [CssClass("fa-cheese-swiss")]
        CheeseSwiss,

        [CssClass("fa-cheeseburger")]
        Cheeseburger,

        [CssClass("fa-chess")]
        Chess,

        [CssClass("fa-chess-bishop")]
        ChessBishop,

        [CssClass("fa-chess-bishop-alt")]
        ChessBishopAlt,

        [CssClass("fa-chess-board")]
        ChessBoard,

        [CssClass("fa-chess-clock")]
        ChessClock,

        [CssClass("fa-chess-clock-alt")]
        ChessClockAlt,

        [CssClass("fa-chess-king")]
        ChessKing,

        [CssClass("fa-chess-king-alt")]
        ChessKingAlt,

        [CssClass("fa-chess-knight")]
        ChessKnight,

        [CssClass("fa-chess-knight-alt")]
        ChessKnightAlt,

        [CssClass("fa-chess-pawn")]
        ChessPawn,

        [CssClass("fa-chess-pawn-alt")]
        ChessPawnAlt,

        [CssClass("fa-chess-queen")]
        ChessQueen,

        [CssClass("fa-chess-queen-alt")]
        ChessQueenAlt,

        [CssClass("fa-chess-rook")]
        ChessRook,

        [CssClass("fa-chess-rook-alt")]
        ChessRookAlt,

        [CssClass("fa-chevron-circle-down")]
        ChevronCircleDown,

        [CssClass("fa-chevron-circle-left")]
        ChevronCircleLeft,

        [CssClass("fa-chevron-circle-right")]
        ChevronCircleRight,

        [CssClass("fa-chevron-circle-up")]
        ChevronCircleUp,

        [CssClass("fa-chevron-double-down")]
        ChevronDoubleDown,

        [CssClass("fa-chevron-double-left")]
        ChevronDoubleLeft,

        [CssClass("fa-chevron-double-right")]
        ChevronDoubleRight,

        [CssClass("fa-chevron-double-up")]
        ChevronDoubleUp,

        [CssClass("fa-chevron-down")]
        ChevronDown,

        [CssClass("fa-chevron-left")]
        ChevronLeft,

        [CssClass("fa-chevron-right")]
        ChevronRight,

        [CssClass("fa-chevron-square-down")]
        ChevronSquareDown,

        [CssClass("fa-chevron-square-left")]
        ChevronSquareLeft,

        [CssClass("fa-chevron-square-right")]
        ChevronSquareRight,

        [CssClass("fa-chevron-square-up")]
        ChevronSquareUp,

        [CssClass("fa-chevron-up")]
        ChevronUp,

        [CssClass("fa-child")]
        Child,

        [CssClass("fa-chimney")]
        Chimney,

        [CssClass("fa-chrome")]
        Chrome,

        [CssClass("fa-chromecast")]
        Chromecast,

        [CssClass("fa-church")]
        Church,

        [CssClass("fa-circle")]
        Circle,

        [CssClass("fa-circle-notch")]
        CircleNotch,

        [CssClass("fa-city")]
        City,

        [CssClass("fa-clarinet")]
        Clarinet,

        [CssClass("fa-claw-marks")]
        ClawMarks,

        [CssClass("fa-clinic-medical")]
        ClinicMedical,

        [CssClass("fa-clipboard")]
        Clipboard,

        [CssClass("fa-clipboard-check")]
        ClipboardCheck,

        [CssClass("fa-clipboard-list")]
        ClipboardList,

        [CssClass("fa-clipboard-list-check")]
        ClipboardListCheck,

        [CssClass("fa-clipboard-prescription")]
        ClipboardPrescription,

        [CssClass("fa-clipboard-user")]
        ClipboardUser,

        [CssClass("fa-clock")]
        Clock,

        [CssClass("fa-clone")]
        Clone,

        [CssClass("fa-closed-captioning")]
        ClosedCaptioning,

        [CssClass("fa-cloud")]
        Cloud,

        [CssClass("fa-cloud-download")]
        CloudDownload,

        [CssClass("fa-cloud-download-alt")]
        CloudDownloadAlt,

        [CssClass("fa-cloud-drizzle")]
        CloudDrizzle,

        [CssClass("fa-cloud-hail")]
        CloudHail,

        [CssClass("fa-cloud-hail-mixed")]
        CloudHailMixed,

        [CssClass("fa-cloud-meatball")]
        CloudMeatball,

        [CssClass("fa-cloud-moon")]
        CloudMoon,

        [CssClass("fa-cloud-moon-rain")]
        CloudMoonRain,

        [CssClass("fa-cloud-music")]
        CloudMusic,

        [CssClass("fa-cloud-rain")]
        CloudRain,

        [CssClass("fa-cloud-rainbow")]
        CloudRainbow,

        [CssClass("fa-cloud-showers")]
        CloudShowers,

        [CssClass("fa-cloud-showers-heavy")]
        CloudShowersHeavy,

        [CssClass("fa-cloud-sleet")]
        CloudSleet,

        [CssClass("fa-cloud-snow")]
        CloudSnow,

        [CssClass("fa-cloud-sun")]
        CloudSun,

        [CssClass("fa-cloud-sun-rain")]
        CloudSunRain,

        [CssClass("fa-cloud-upload")]
        CloudUpload,

        [CssClass("fa-cloud-upload-alt")]
        CloudUploadAlt,

        [CssClass("fa-cloudflare")]
        Cloudflare,

        [CssClass("fa-clouds")]
        Clouds,

        [CssClass("fa-clouds-moon")]
        CloudsMoon,

        [CssClass("fa-clouds-sun")]
        CloudsSun,

        [CssClass("fa-cloudscale")]
        Cloudscale,

        [CssClass("fa-cloudsmith")]
        Cloudsmith,

        [CssClass("fa-cloudversify")]
        Cloudversify,

        [CssClass("fa-club")]
        Club,

        [CssClass("fa-cocktail")]
        Cocktail,

        [CssClass("fa-code")]
        Code,

        [CssClass("fa-code-branch")]
        CodeBranch,

        [CssClass("fa-code-commit")]
        CodeCommit,

        [CssClass("fa-code-merge")]
        CodeMerge,

        [CssClass("fa-codepen")]
        Codepen,

        [CssClass("fa-codiepie")]
        Codiepie,

        [CssClass("fa-coffee")]
        Coffee,

        [CssClass("fa-coffee-pot")]
        CoffeePot,

        [CssClass("fa-coffee-togo")]
        CoffeeTogo,

        [CssClass("fa-coffin")]
        Coffin,

        [CssClass("fa-coffin-cross")]
        CoffinCross,

        [CssClass("fa-cog")]
        Cog,

        [CssClass("fa-cogs")]
        Cogs,

        [CssClass("fa-coin")]
        Coin,

        [CssClass("fa-coins")]
        Coins,

        [CssClass("fa-columns")]
        Columns,

        [CssClass("fa-comet")]
        Comet,

        [CssClass("fa-comment")]
        Comment,

        [CssClass("fa-comment-alt")]
        CommentAlt,

        [CssClass("fa-comment-alt-check")]
        CommentAltCheck,

        [CssClass("fa-comment-alt-dollar")]
        CommentAltDollar,

        [CssClass("fa-comment-alt-dots")]
        CommentAltDots,

        [CssClass("fa-comment-alt-edit")]
        CommentAltEdit,

        [CssClass("fa-comment-alt-exclamation")]
        CommentAltExclamation,

        [CssClass("fa-comment-alt-lines")]
        CommentAltLines,

        [CssClass("fa-comment-alt-medical")]
        CommentAltMedical,

        [CssClass("fa-comment-alt-minus")]
        CommentAltMinus,

        [CssClass("fa-comment-alt-music")]
        CommentAltMusic,

        [CssClass("fa-comment-alt-plus")]
        CommentAltPlus,

        [CssClass("fa-comment-alt-slash")]
        CommentAltSlash,

        [CssClass("fa-comment-alt-smile")]
        CommentAltSmile,

        [CssClass("fa-comment-alt-times")]
        CommentAltTimes,

        [CssClass("fa-comment-check")]
        CommentCheck,

        [CssClass("fa-comment-dollar")]
        CommentDollar,

        [CssClass("fa-comment-dots")]
        CommentDots,

        [CssClass("fa-comment-edit")]
        CommentEdit,

        [CssClass("fa-comment-exclamation")]
        CommentExclamation,

        [CssClass("fa-comment-lines")]
        CommentLines,

        [CssClass("fa-comment-medical")]
        CommentMedical,

        [CssClass("fa-comment-minus")]
        CommentMinus,

        [CssClass("fa-comment-music")]
        CommentMusic,

        [CssClass("fa-comment-plus")]
        CommentPlus,

        [CssClass("fa-comment-slash")]
        CommentSlash,

        [CssClass("fa-comment-smile")]
        CommentSmile,

        [CssClass("fa-comment-times")]
        CommentTimes,

        [CssClass("fa-comments")]
        Comments,

        [CssClass("fa-comments-alt")]
        CommentsAlt,

        [CssClass("fa-comments-alt-dollar")]
        CommentsAltDollar,

        [CssClass("fa-comments-dollar")]
        CommentsDollar,

        [CssClass("fa-compact-disc")]
        CompactDisc,

        [CssClass("fa-compass")]
        Compass,

        [CssClass("fa-compass-slash")]
        CompassSlash,

        [CssClass("fa-compress")]
        Compress,

        [CssClass("fa-compress-alt")]
        CompressAlt,

        [CssClass("fa-compress-arrows-alt")]
        CompressArrowsAlt,

        [CssClass("fa-compress-wide")]
        CompressWide,

        [CssClass("fa-computer-classic")]
        ComputerClassic,

        [CssClass("fa-computer-speaker")]
        ComputerSpeaker,

        [CssClass("fa-concierge-bell")]
        ConciergeBell,

        [CssClass("fa-confluence")]
        Confluence,

        [CssClass("fa-connectdevelop")]
        Connectdevelop,

        [CssClass("fa-construction")]
        Construction,

        [CssClass("fa-container-storage")]
        ContainerStorage,

        [CssClass("fa-contao")]
        Contao,

        [CssClass("fa-conveyor-belt")]
        ConveyorBelt,

        [CssClass("fa-conveyor-belt-alt")]
        ConveyorBeltAlt,

        [CssClass("fa-cookie")]
        Cookie,

        [CssClass("fa-cookie-bite")]
        CookieBite,

        [CssClass("fa-copy")]
        Copy,

        [CssClass("fa-copyright")]
        Copyright,

        [CssClass("fa-corn")]
        Corn,

        [CssClass("fa-cotton-bureau")]
        CottonBureau,

        [CssClass("fa-couch")]
        Couch,

        [CssClass("fa-cow")]
        Cow,

        [CssClass("fa-cowbell")]
        Cowbell,

        [CssClass("fa-cowbell-more")]
        CowbellMore,

        [CssClass("fa-cpanel")]
        Cpanel,

        [CssClass("fa-creative-commons")]
        CreativeCommons,

        [CssClass("fa-creative-commons-by")]
        CreativeCommonsBy,

        [CssClass("fa-creative-commons-nc")]
        CreativeCommonsNc,

        [CssClass("fa-creative-commons-nc-eu")]
        CreativeCommonsNcEu,

        [CssClass("fa-creative-commons-nc-jp")]
        CreativeCommonsNcJp,

        [CssClass("fa-creative-commons-nd")]
        CreativeCommonsNd,

        [CssClass("fa-creative-commons-pd")]
        CreativeCommonsPd,

        [CssClass("fa-creative-commons-pd-alt")]
        CreativeCommonsPdAlt,

        [CssClass("fa-creative-commons-remix")]
        CreativeCommonsRemix,

        [CssClass("fa-creative-commons-sa")]
        CreativeCommonsSa,

        [CssClass("fa-creative-commons-sampling")]
        CreativeCommonsSampling,

        [CssClass("fa-creative-commons-sampling-plus")]
        CreativeCommonsSamplingPlus,

        [CssClass("fa-creative-commons-share")]
        CreativeCommonsShare,

        [CssClass("fa-creative-commons-zero")]
        CreativeCommonsZero,

        [CssClass("fa-credit-card")]
        CreditCard,

        [CssClass("fa-credit-card-blank")]
        CreditCardBlank,

        [CssClass("fa-credit-card-front")]
        CreditCardFront,

        [CssClass("fa-cricket")]
        Cricket,

        [CssClass("fa-critical-role")]
        CriticalRole,

        [CssClass("fa-croissant")]
        Croissant,

        [CssClass("fa-crop")]
        Crop,

        [CssClass("fa-crop-alt")]
        CropAlt,

        [CssClass("fa-cross")]
        Cross,

        [CssClass("fa-crosshairs")]
        Crosshairs,

        [CssClass("fa-crow")]
        Crow,

        [CssClass("fa-crown")]
        Crown,

        [CssClass("fa-crutch")]
        Crutch,

        [CssClass("fa-crutches")]
        Crutches,

        [CssClass("fa-css3")]
        Css3,

        [CssClass("fa-css3-alt")]
        Css3Alt,

        [CssClass("fa-cube")]
        Cube,

        [CssClass("fa-cubes")]
        Cubes,

        [CssClass("fa-curling")]
        Curling,

        [CssClass("fa-cut")]
        Cut,

        [CssClass("fa-cuttlefish")]
        Cuttlefish,

        [CssClass("fa-d-and-d")]
        DAndD,

        [CssClass("fa-d-and-d-beyond")]
        DAndDBeyond,

        [CssClass("fa-dagger")]
        Dagger,

        [CssClass("fa-dailymotion")]
        Dailymotion,

        [CssClass("fa-dashcube")]
        Dashcube,

        [CssClass("fa-database")]
        Database,

        [CssClass("fa-deaf")]
        Deaf,

        [CssClass("fa-debug")]
        Debug,

        [CssClass("fa-deer")]
        Deer,

        [CssClass("fa-deer-rudolph")]
        DeerRudolph,

        [CssClass("fa-deezer")]
        Deezer,

        [CssClass("fa-delicious")]
        Delicious,

        [CssClass("fa-democrat")]
        Democrat,

        [CssClass("fa-deploydog")]
        Deploydog,

        [CssClass("fa-deskpro")]
        Deskpro,

        [CssClass("fa-desktop")]
        Desktop,

        [CssClass("fa-desktop-alt")]
        DesktopAlt,

        [CssClass("fa-dev")]
        Dev,

        [CssClass("fa-deviantart")]
        Deviantart,

        [CssClass("fa-dewpoint")]
        Dewpoint,

        [CssClass("fa-dharmachakra")]
        Dharmachakra,

        [CssClass("fa-dhl")]
        Dhl,

        [CssClass("fa-diagnoses")]
        Diagnoses,

        [CssClass("fa-diamond")]
        Diamond,

        [CssClass("fa-diaspora")]
        Diaspora,

        [CssClass("fa-dice")]
        Dice,

        [CssClass("fa-dice-d10")]
        DiceD10,

        [CssClass("fa-dice-d12")]
        DiceD12,

        [CssClass("fa-dice-d20")]
        DiceD20,

        [CssClass("fa-dice-d4")]
        DiceD4,

        [CssClass("fa-dice-d6")]
        DiceD6,

        [CssClass("fa-dice-d8")]
        DiceD8,

        [CssClass("fa-dice-five")]
        DiceFive,

        [CssClass("fa-dice-four")]
        DiceFour,

        [CssClass("fa-dice-one")]
        DiceOne,

        [CssClass("fa-dice-six")]
        DiceSix,

        [CssClass("fa-dice-three")]
        DiceThree,

        [CssClass("fa-dice-two")]
        DiceTwo,

        [CssClass("fa-digg")]
        Digg,

        [CssClass("fa-digging")]
        Digging,

        [CssClass("fa-digital-ocean")]
        DigitalOcean,

        [CssClass("fa-digital-tachograph")]
        DigitalTachograph,

        [CssClass("fa-diploma")]
        Diploma,

        [CssClass("fa-directions")]
        Directions,

        [CssClass("fa-disc-drive")]
        DiscDrive,

        [CssClass("fa-discord")]
        Discord,

        [CssClass("fa-discourse")]
        Discourse,

        [CssClass("fa-disease")]
        Disease,

        [CssClass("fa-divide")]
        Divide,

        [CssClass("fa-dizzy")]
        Dizzy,

        [CssClass("fa-dna")]
        Dna,

        [CssClass("fa-do-not-enter")]
        DoNotEnter,

        [CssClass("fa-dochub")]
        Dochub,

        [CssClass("fa-docker")]
        Docker,

        [CssClass("fa-dog")]
        Dog,

        [CssClass("fa-dog-leashed")]
        DogLeashed,

        [CssClass("fa-dollar-sign")]
        DollarSign,

        [CssClass("fa-dolly")]
        Dolly,

        [CssClass("fa-dolly-empty")]
        DollyEmpty,

        [CssClass("fa-dolly-flatbed")]
        DollyFlatbed,

        [CssClass("fa-dolly-flatbed-alt")]
        DollyFlatbedAlt,

        [CssClass("fa-dolly-flatbed-empty")]
        DollyFlatbedEmpty,

        [CssClass("fa-donate")]
        Donate,

        [CssClass("fa-door-closed")]
        DoorClosed,

        [CssClass("fa-door-open")]
        DoorOpen,

        [CssClass("fa-dot-circle")]
        DotCircle,

        [CssClass("fa-dove")]
        Dove,

        [CssClass("fa-download")]
        Download,

        [CssClass("fa-draft2digital")]
        Draft2digital,

        [CssClass("fa-drafting-compass")]
        DraftingCompass,

        [CssClass("fa-dragon")]
        Dragon,

        [CssClass("fa-draw-circle")]
        DrawCircle,

        [CssClass("fa-draw-polygon")]
        DrawPolygon,

        [CssClass("fa-draw-square")]
        DrawSquare,

        [CssClass("fa-dreidel")]
        Dreidel,

        [CssClass("fa-dribbble")]
        Dribbble,

        [CssClass("fa-dribbble-square")]
        DribbbleSquare,

        [CssClass("fa-drone")]
        Drone,

        [CssClass("fa-drone-alt")]
        DroneAlt,

        [CssClass("fa-dropbox")]
        Dropbox,

        [CssClass("fa-drum")]
        Drum,

        [CssClass("fa-drum-steelpan")]
        DrumSteelpan,

        [CssClass("fa-drumstick")]
        Drumstick,

        [CssClass("fa-drumstick-bite")]
        DrumstickBite,

        [CssClass("fa-drupal")]
        Drupal,

        [CssClass("fa-dryer")]
        Dryer,

        [CssClass("fa-dryer-alt")]
        DryerAlt,

        [CssClass("fa-duck")]
        Duck,

        [CssClass("fa-dumbbell")]
        Dumbbell,

        [CssClass("fa-dumpster")]
        Dumpster,

        [CssClass("fa-dumpster-fire")]
        DumpsterFire,

        [CssClass("fa-dungeon")]
        Dungeon,

        [CssClass("fa-dyalog")]
        Dyalog,

        [CssClass("fa-ear")]
        Ear,

        [CssClass("fa-ear-muffs")]
        EarMuffs,

        [CssClass("fa-earlybirds")]
        Earlybirds,

        [CssClass("fa-ebay")]
        Ebay,

        [CssClass("fa-eclipse")]
        Eclipse,

        [CssClass("fa-eclipse-alt")]
        EclipseAlt,

        [CssClass("fa-edge")]
        Edge,

        [CssClass("fa-edge-legacy")]
        EdgeLegacy,

        [CssClass("fa-edit")]
        Edit,

        [CssClass("fa-egg")]
        Egg,

        [CssClass("fa-egg-fried")]
        EggFried,

        [CssClass("fa-eject")]
        Eject,

        [CssClass("fa-elementor")]
        Elementor,

        [CssClass("fa-elephant")]
        Elephant,

        [CssClass("fa-ellipsis-h")]
        EllipsisH,

        [CssClass("fa-ellipsis-h-alt")]
        EllipsisHAlt,

        [CssClass("fa-ellipsis-v")]
        EllipsisV,

        [CssClass("fa-ellipsis-v-alt")]
        EllipsisVAlt,

        [CssClass("fa-ello")]
        Ello,

        [CssClass("fa-ember")]
        Ember,

        [CssClass("fa-empire")]
        Empire,

        [CssClass("fa-empty-set")]
        EmptySet,

        [CssClass("fa-engine-warning")]
        EngineWarning,

        [CssClass("fa-envelope")]
        Envelope,

        [CssClass("fa-envelope-open")]
        EnvelopeOpen,

        [CssClass("fa-envelope-open-dollar")]
        EnvelopeOpenDollar,

        [CssClass("fa-envelope-open-text")]
        EnvelopeOpenText,

        [CssClass("fa-envelope-square")]
        EnvelopeSquare,

        [CssClass("fa-envira")]
        Envira,

        [CssClass("fa-equals")]
        Equals,

        [CssClass("fa-eraser")]
        Eraser,

        [CssClass("fa-erlang")]
        Erlang,

        [CssClass("fa-ethereum")]
        Ethereum,

        [CssClass("fa-ethernet")]
        Ethernet,

        [CssClass("fa-etsy")]
        Etsy,

        [CssClass("fa-euro-sign")]
        EuroSign,

        [CssClass("fa-evernote")]
        Evernote,

        [CssClass("fa-exchange")]
        Exchange,

        [CssClass("fa-exchange-alt")]
        ExchangeAlt,

        [CssClass("fa-exclamation")]
        Exclamation,

        [CssClass("fa-exclamation-circle")]
        ExclamationCircle,

        [CssClass("fa-exclamation-square")]
        ExclamationSquare,

        [CssClass("fa-exclamation-triangle")]
        ExclamationTriangle,

        [CssClass("fa-expand")]
        Expand,

        [CssClass("fa-expand-alt")]
        ExpandAlt,

        [CssClass("fa-expand-arrows")]
        ExpandArrows,

        [CssClass("fa-expand-arrows-alt")]
        ExpandArrowsAlt,

        [CssClass("fa-expand-wide")]
        ExpandWide,

        [CssClass("fa-expeditedssl")]
        Expeditedssl,

        [CssClass("fa-external-link")]
        ExternalLink,

        [CssClass("fa-external-link-alt")]
        ExternalLinkAlt,

        [CssClass("fa-external-link-square")]
        ExternalLinkSquare,

        [CssClass("fa-external-link-square-alt")]
        ExternalLinkSquareAlt,

        [CssClass("fa-eye")]
        Eye,

        [CssClass("fa-eye-dropper")]
        EyeDropper,

        [CssClass("fa-eye-evil")]
        EyeEvil,

        [CssClass("fa-eye-slash")]
        EyeSlash,

        [CssClass("fa-facebook")]
        Facebook,

        [CssClass("fa-facebook-f")]
        FacebookF,

        [CssClass("fa-facebook-messenger")]
        FacebookMessenger,

        [CssClass("fa-facebook-square")]
        FacebookSquare,

        [CssClass("fa-fan")]
        Fan,

        [CssClass("fa-fan-table")]
        FanTable,

        [CssClass("fa-fantasy-flight-games")]
        FantasyFlightGames,

        [CssClass("fa-farm")]
        Farm,

        [CssClass("fa-fast-backward")]
        FastBackward,

        [CssClass("fa-fast-forward")]
        FastForward,

        [CssClass("fa-faucet")]
        Faucet,

        [CssClass("fa-faucet-drip")]
        FaucetDrip,

        [CssClass("fa-fax")]
        Fax,

        [CssClass("fa-feather")]
        Feather,

        [CssClass("fa-feather-alt")]
        FeatherAlt,

        [CssClass("fa-fedex")]
        Fedex,

        [CssClass("fa-fedora")]
        Fedora,

        [CssClass("fa-female")]
        Female,

        [CssClass("fa-field-hockey")]
        FieldHockey,

        [CssClass("fa-fighter-jet")]
        FighterJet,

        [CssClass("fa-figma")]
        Figma,

        [CssClass("fa-file")]
        File,

        [CssClass("fa-file-alt")]
        FileAlt,

        [CssClass("fa-file-archive")]
        FileArchive,

        [CssClass("fa-file-audio")]
        FileAudio,

        [CssClass("fa-file-certificate")]
        FileCertificate,

        [CssClass("fa-file-chart-line")]
        FileChartLine,

        [CssClass("fa-file-chart-pie")]
        FileChartPie,

        [CssClass("fa-file-check")]
        FileCheck,

        [CssClass("fa-file-code")]
        FileCode,

        [CssClass("fa-file-contract")]
        FileContract,

        [CssClass("fa-file-csv")]
        FileCsv,

        [CssClass("fa-file-download")]
        FileDownload,

        [CssClass("fa-file-edit")]
        FileEdit,

        [CssClass("fa-file-excel")]
        FileExcel,

        [CssClass("fa-file-exclamation")]
        FileExclamation,

        [CssClass("fa-file-export")]
        FileExport,

        [CssClass("fa-file-image")]
        FileImage,

        [CssClass("fa-file-import")]
        FileImport,

        [CssClass("fa-file-invoice")]
        FileInvoice,

        [CssClass("fa-file-invoice-dollar")]
        FileInvoiceDollar,

        [CssClass("fa-file-medical")]
        FileMedical,

        [CssClass("fa-file-medical-alt")]
        FileMedicalAlt,

        [CssClass("fa-file-minus")]
        FileMinus,

        [CssClass("fa-file-music")]
        FileMusic,

        [CssClass("fa-file-pdf")]
        FilePdf,

        [CssClass("fa-file-plus")]
        FilePlus,

        [CssClass("fa-file-powerpoint")]
        FilePowerpoint,

        [CssClass("fa-file-prescription")]
        FilePrescription,

        [CssClass("fa-file-search")]
        FileSearch,

        [CssClass("fa-file-signature")]
        FileSignature,

        [CssClass("fa-file-spreadsheet")]
        FileSpreadsheet,

        [CssClass("fa-file-times")]
        FileTimes,

        [CssClass("fa-file-upload")]
        FileUpload,

        [CssClass("fa-file-user")]
        FileUser,

        [CssClass("fa-file-video")]
        FileVideo,

        [CssClass("fa-file-word")]
        FileWord,

        [CssClass("fa-files-medical")]
        FilesMedical,

        [CssClass("fa-fill")]
        Fill,

        [CssClass("fa-fill-drip")]
        FillDrip,

        [CssClass("fa-film")]
        Film,

        [CssClass("fa-film-alt")]
        FilmAlt,

        [CssClass("fa-film-canister")]
        FilmCanister,

        [CssClass("fa-filter")]
        Filter,

        [CssClass("fa-fingerprint")]
        Fingerprint,

        [CssClass("fa-fire")]
        Fire,

        [CssClass("fa-fire-alt")]
        FireAlt,

        [CssClass("fa-fire-extinguisher")]
        FireExtinguisher,

        [CssClass("fa-fire-smoke")]
        FireSmoke,

        [CssClass("fa-firefox")]
        Firefox,

        [CssClass("fa-firefox-browser")]
        FirefoxBrowser,

        [CssClass("fa-fireplace")]
        Fireplace,

        [CssClass("fa-first-aid")]
        FirstAid,

        [CssClass("fa-first-order")]
        FirstOrder,

        [CssClass("fa-first-order-alt")]
        FirstOrderAlt,

        [CssClass("fa-firstdraft")]
        Firstdraft,

        [CssClass("fa-fish")]
        Fish,

        [CssClass("fa-fish-cooked")]
        FishCooked,

        [CssClass("fa-fist-raised")]
        FistRaised,

        [CssClass("fa-flag")]
        Flag,

        [CssClass("fa-flag-alt")]
        FlagAlt,

        [CssClass("fa-flag-checkered")]
        FlagCheckered,

        [CssClass("fa-flag-usa")]
        FlagUsa,

        [CssClass("fa-flame")]
        Flame,

        [CssClass("fa-flashlight")]
        Flashlight,

        [CssClass("fa-flask")]
        Flask,

        [CssClass("fa-flask-poison")]
        FlaskPoison,

        [CssClass("fa-flask-potion")]
        FlaskPotion,

        [CssClass("fa-flickr")]
        Flickr,

        [CssClass("fa-flipboard")]
        Flipboard,

        [CssClass("fa-flower")]
        Flower,

        [CssClass("fa-flower-daffodil")]
        FlowerDaffodil,

        [CssClass("fa-flower-tulip")]
        FlowerTulip,

        [CssClass("fa-flushed")]
        Flushed,

        [CssClass("fa-flute")]
        Flute,

        [CssClass("fa-flux-capacitor")]
        FluxCapacitor,

        [CssClass("fa-fly")]
        Fly,

        [CssClass("fa-fog")]
        Fog,

        [CssClass("fa-folder")]
        Folder,

        [CssClass("fa-folder-download")]
        FolderDownload,

        [CssClass("fa-folder-minus")]
        FolderMinus,

        [CssClass("fa-folder-open")]
        FolderOpen,

        [CssClass("fa-folder-plus")]
        FolderPlus,

        [CssClass("fa-folder-times")]
        FolderTimes,

        [CssClass("fa-folder-tree")]
        FolderTree,

        [CssClass("fa-folder-upload")]
        FolderUpload,

        [CssClass("fa-folders")]
        Folders,

        [CssClass("fa-font")]
        Font,

        [CssClass("fa-font-awesome")]
        FontAwesome,

        [CssClass("fa-font-awesome-alt")]
        FontAwesomeAlt,

        [CssClass("fa-font-awesome-flag")]
        FontAwesomeFlag,

        [CssClass("fa-font-awesome-logo-full")]
        FontAwesomeLogoFull,

        [CssClass("fa-font-case")]
        FontCase,

        [CssClass("fa-fonticons")]
        Fonticons,

        [CssClass("fa-fonticons-fi")]
        FonticonsFi,

        [CssClass("fa-football-ball")]
        FootballBall,

        [CssClass("fa-football-helmet")]
        FootballHelmet,

        [CssClass("fa-forklift")]
        Forklift,

        [CssClass("fa-fort-awesome")]
        FortAwesome,

        [CssClass("fa-fort-awesome-alt")]
        FortAwesomeAlt,

        [CssClass("fa-forumbee")]
        Forumbee,

        [CssClass("fa-forward")]
        Forward,

        [CssClass("fa-foursquare")]
        Foursquare,

        [CssClass("fa-fragile")]
        Fragile,

        [CssClass("fa-free-code-camp")]
        FreeCodeCamp,

        [CssClass("fa-freebsd")]
        Freebsd,

        [CssClass("fa-french-fries")]
        FrenchFries,

        [CssClass("fa-frog")]
        Frog,

        [CssClass("fa-frosty-head")]
        FrostyHead,

        [CssClass("fa-frown")]
        Frown,

        [CssClass("fa-frown-open")]
        FrownOpen,

        [CssClass("fa-fulcrum")]
        Fulcrum,

        [CssClass("fa-function")]
        Function,

        [CssClass("fa-funnel-dollar")]
        FunnelDollar,

        [CssClass("fa-futbol")]
        Futbol,

        [CssClass("fa-galactic-republic")]
        GalacticRepublic,

        [CssClass("fa-galactic-senate")]
        GalacticSenate,

        [CssClass("fa-galaxy")]
        Galaxy,

        [CssClass("fa-game-board")]
        GameBoard,

        [CssClass("fa-game-board-alt")]
        GameBoardAlt,

        [CssClass("fa-game-console-handheld")]
        GameConsoleHandheld,

        [CssClass("fa-gamepad")]
        Gamepad,

        [CssClass("fa-gamepad-alt")]
        GamepadAlt,

        [CssClass("fa-garage")]
        Garage,

        [CssClass("fa-garage-car")]
        GarageCar,

        [CssClass("fa-garage-open")]
        GarageOpen,

        [CssClass("fa-gas-pump")]
        GasPump,

        [CssClass("fa-gas-pump-slash")]
        GasPumpSlash,

        [CssClass("fa-gavel")]
        Gavel,

        [CssClass("fa-gem")]
        Gem,

        [CssClass("fa-genderless")]
        Genderless,

        [CssClass("fa-get-pocket")]
        GetPocket,

        [CssClass("fa-gg")]
        Gg,

        [CssClass("fa-gg-circle")]
        GgCircle,

        [CssClass("fa-ghost")]
        Ghost,

        [CssClass("fa-gift")]
        Gift,

        [CssClass("fa-gift-card")]
        GiftCard,

        [CssClass("fa-gifts")]
        Gifts,

        [CssClass("fa-gingerbread-man")]
        GingerbreadMan,

        [CssClass("fa-git")]
        Git,

        [CssClass("fa-git-alt")]
        GitAlt,

        [CssClass("fa-git-square")]
        GitSquare,

        [CssClass("fa-github")]
        Github,

        [CssClass("fa-github-alt")]
        GithubAlt,

        [CssClass("fa-github-square")]
        GithubSquare,

        [CssClass("fa-gitkraken")]
        Gitkraken,

        [CssClass("fa-gitlab")]
        Gitlab,

        [CssClass("fa-gitter")]
        Gitter,

        [CssClass("fa-glass")]
        Glass,

        [CssClass("fa-glass-champagne")]
        GlassChampagne,

        [CssClass("fa-glass-cheers")]
        GlassCheers,

        [CssClass("fa-glass-citrus")]
        GlassCitrus,

        [CssClass("fa-glass-martini")]
        GlassMartini,

        [CssClass("fa-glass-martini-alt")]
        GlassMartiniAlt,

        [CssClass("fa-glass-whiskey")]
        GlassWhiskey,

        [CssClass("fa-glass-whiskey-rocks")]
        GlassWhiskeyRocks,

        [CssClass("fa-glasses")]
        Glasses,

        [CssClass("fa-glasses-alt")]
        GlassesAlt,

        [CssClass("fa-glide")]
        Glide,

        [CssClass("fa-glide-g")]
        GlideG,

        [CssClass("fa-globe")]
        Globe,

        [CssClass("fa-globe-africa")]
        GlobeAfrica,

        [CssClass("fa-globe-americas")]
        GlobeAmericas,

        [CssClass("fa-globe-asia")]
        GlobeAsia,

        [CssClass("fa-globe-europe")]
        GlobeEurope,

        [CssClass("fa-globe-snow")]
        GlobeSnow,

        [CssClass("fa-globe-stand")]
        GlobeStand,

        [CssClass("fa-gofore")]
        Gofore,

        [CssClass("fa-golf-ball")]
        GolfBall,

        [CssClass("fa-golf-club")]
        GolfClub,

        [CssClass("fa-goodreads")]
        Goodreads,

        [CssClass("fa-goodreads-g")]
        GoodreadsG,

        [CssClass("fa-google")]
        Google,

        [CssClass("fa-google-drive")]
        GoogleDrive,

        [CssClass("fa-google-pay")]
        GooglePay,

        [CssClass("fa-google-play")]
        GooglePlay,

        [CssClass("fa-google-plus")]
        GooglePlus,

        [CssClass("fa-google-plus-g")]
        GooglePlusG,

        [CssClass("fa-google-plus-square")]
        GooglePlusSquare,

        [CssClass("fa-google-wallet")]
        GoogleWallet,

        [CssClass("fa-gopuram")]
        Gopuram,

        [CssClass("fa-graduation-cap")]
        GraduationCap,

        [CssClass("fa-gramophone")]
        Gramophone,

        [CssClass("fa-gratipay")]
        Gratipay,

        [CssClass("fa-grav")]
        Grav,

        [CssClass("fa-greater-than")]
        GreaterThan,

        [CssClass("fa-greater-than-equal")]
        GreaterThanEqual,

        [CssClass("fa-grimace")]
        Grimace,

        [CssClass("fa-grin")]
        Grin,

        [CssClass("fa-grin-alt")]
        GrinAlt,

        [CssClass("fa-grin-beam")]
        GrinBeam,

        [CssClass("fa-grin-beam-sweat")]
        GrinBeamSweat,

        [CssClass("fa-grin-hearts")]
        GrinHearts,

        [CssClass("fa-grin-squint")]
        GrinSquint,

        [CssClass("fa-grin-squint-tears")]
        GrinSquintTears,

        [CssClass("fa-grin-stars")]
        GrinStars,

        [CssClass("fa-grin-tears")]
        GrinTears,

        [CssClass("fa-grin-tongue")]
        GrinTongue,

        [CssClass("fa-grin-tongue-squint")]
        GrinTongueSquint,

        [CssClass("fa-grin-tongue-wink")]
        GrinTongueWink,

        [CssClass("fa-grin-wink")]
        GrinWink,

        [CssClass("fa-grip-horizontal")]
        GripHorizontal,

        [CssClass("fa-grip-lines")]
        GripLines,

        [CssClass("fa-grip-lines-vertical")]
        GripLinesVertical,

        [CssClass("fa-grip-vertical")]
        GripVertical,

        [CssClass("fa-gripfire")]
        Gripfire,

        [CssClass("fa-grunt")]
        Grunt,

        [CssClass("fa-guilded")]
        Guilded,

        [CssClass("fa-guitar")]
        Guitar,

        [CssClass("fa-guitar-electric")]
        GuitarElectric,

        [CssClass("fa-guitars")]
        Guitars,

        [CssClass("fa-gulp")]
        Gulp,

        [CssClass("fa-h-square")]
        HSquare,

        [CssClass("fa-h1")]
        H1,

        [CssClass("fa-h2")]
        H2,

        [CssClass("fa-h3")]
        H3,

        [CssClass("fa-h4")]
        H4,

        [CssClass("fa-hacker-news")]
        HackerNews,

        [CssClass("fa-hacker-news-square")]
        HackerNewsSquare,

        [CssClass("fa-hackerrank")]
        Hackerrank,

        [CssClass("fa-hamburger")]
        Hamburger,

        [CssClass("fa-hammer")]
        Hammer,

        [CssClass("fa-hammer-war")]
        HammerWar,

        [CssClass("fa-hamsa")]
        Hamsa,

        [CssClass("fa-hand-heart")]
        HandHeart,

        [CssClass("fa-hand-holding")]
        HandHolding,

        [CssClass("fa-hand-holding-box")]
        HandHoldingBox,

        [CssClass("fa-hand-holding-heart")]
        HandHoldingHeart,

        [CssClass("fa-hand-holding-magic")]
        HandHoldingMagic,

        [CssClass("fa-hand-holding-medical")]
        HandHoldingMedical,

        [CssClass("fa-hand-holding-seedling")]
        HandHoldingSeedling,

        [CssClass("fa-hand-holding-usd")]
        HandHoldingUsd,

        [CssClass("fa-hand-holding-water")]
        HandHoldingWater,

        [CssClass("fa-hand-lizard")]
        HandLizard,

        [CssClass("fa-hand-middle-finger")]
        HandMiddleFinger,

        [CssClass("fa-hand-paper")]
        HandPaper,

        [CssClass("fa-hand-peace")]
        HandPeace,

        [CssClass("fa-hand-point-down")]
        HandPointDown,

        [CssClass("fa-hand-point-left")]
        HandPointLeft,

        [CssClass("fa-hand-point-right")]
        HandPointRight,

        [CssClass("fa-hand-point-up")]
        HandPointUp,

        [CssClass("fa-hand-pointer")]
        HandPointer,

        [CssClass("fa-hand-receiving")]
        HandReceiving,

        [CssClass("fa-hand-rock")]
        HandRock,

        [CssClass("fa-hand-scissors")]
        HandScissors,

        [CssClass("fa-hand-sparkles")]
        HandSparkles,

        [CssClass("fa-hand-spock")]
        HandSpock,

        [CssClass("fa-hands")]
        Hands,

        [CssClass("fa-hands-heart")]
        HandsHeart,

        [CssClass("fa-hands-helping")]
        HandsHelping,

        [CssClass("fa-hands-usd")]
        HandsUsd,

        [CssClass("fa-hands-wash")]
        HandsWash,

        [CssClass("fa-handshake")]
        Handshake,

        [CssClass("fa-handshake-alt")]
        HandshakeAlt,

        [CssClass("fa-handshake-alt-slash")]
        HandshakeAltSlash,

        [CssClass("fa-handshake-slash")]
        HandshakeSlash,

        [CssClass("fa-hanukiah")]
        Hanukiah,

        [CssClass("fa-hard-hat")]
        HardHat,

        [CssClass("fa-hashtag")]
        Hashtag,

        [CssClass("fa-hat-chef")]
        HatChef,

        [CssClass("fa-hat-cowboy")]
        HatCowboy,

        [CssClass("fa-hat-cowboy-side")]
        HatCowboySide,

        [CssClass("fa-hat-santa")]
        HatSanta,

        [CssClass("fa-hat-winter")]
        HatWinter,

        [CssClass("fa-hat-witch")]
        HatWitch,

        [CssClass("fa-hat-wizard")]
        HatWizard,

        [CssClass("fa-hdd")]
        Hdd,

        [CssClass("fa-head-side")]
        HeadSide,

        [CssClass("fa-head-side-brain")]
        HeadSideBrain,

        [CssClass("fa-head-side-cough")]
        HeadSideCough,

        [CssClass("fa-head-side-cough-slash")]
        HeadSideCoughSlash,

        [CssClass("fa-head-side-headphones")]
        HeadSideHeadphones,

        [CssClass("fa-head-side-mask")]
        HeadSideMask,

        [CssClass("fa-head-side-medical")]
        HeadSideMedical,

        [CssClass("fa-head-side-virus")]
        HeadSideVirus,

        [CssClass("fa-head-vr")]
        HeadVr,

        [CssClass("fa-heading")]
        Heading,

        [CssClass("fa-headphones")]
        Headphones,

        [CssClass("fa-headphones-alt")]
        HeadphonesAlt,

        [CssClass("fa-headset")]
        Headset,

        [CssClass("fa-heart")]
        Heart,

        [CssClass("fa-heart-broken")]
        HeartBroken,

        [CssClass("fa-heart-circle")]
        HeartCircle,

        [CssClass("fa-heart-rate")]
        HeartRate,

        [CssClass("fa-heart-square")]
        HeartSquare,

        [CssClass("fa-heartbeat")]
        Heartbeat,

        [CssClass("fa-heat")]
        Heat,

        [CssClass("fa-helicopter")]
        Helicopter,

        [CssClass("fa-helmet-battle")]
        HelmetBattle,

        [CssClass("fa-hexagon")]
        Hexagon,

        [CssClass("fa-highlighter")]
        Highlighter,

        [CssClass("fa-hiking")]
        Hiking,

        [CssClass("fa-hippo")]
        Hippo,

        [CssClass("fa-hips")]
        Hips,

        [CssClass("fa-hire-a-helper")]
        HireAHelper,

        [CssClass("fa-history")]
        History,

        [CssClass("fa-hive")]
        Hive,

        [CssClass("fa-hockey-mask")]
        HockeyMask,

        [CssClass("fa-hockey-puck")]
        HockeyPuck,

        [CssClass("fa-hockey-sticks")]
        HockeySticks,

        [CssClass("fa-holly-berry")]
        HollyBerry,

        [CssClass("fa-home")]
        Home,

        [CssClass("fa-home-alt")]
        HomeAlt,

        [CssClass("fa-home-heart")]
        HomeHeart,

        [CssClass("fa-home-lg")]
        HomeLg,

        [CssClass("fa-home-lg-alt")]
        HomeLgAlt,

        [CssClass("fa-hood-cloak")]
        HoodCloak,

        [CssClass("fa-hooli")]
        Hooli,

        [CssClass("fa-horizontal-rule")]
        HorizontalRule,

        [CssClass("fa-hornbill")]
        Hornbill,

        [CssClass("fa-horse")]
        Horse,

        [CssClass("fa-horse-head")]
        HorseHead,

        [CssClass("fa-horse-saddle")]
        HorseSaddle,

        [CssClass("fa-hospital")]
        Hospital,

        [CssClass("fa-hospital-alt")]
        HospitalAlt,

        [CssClass("fa-hospital-symbol")]
        HospitalSymbol,

        [CssClass("fa-hospital-user")]
        HospitalUser,

        [CssClass("fa-hospitals")]
        Hospitals,

        [CssClass("fa-hot-tub")]
        HotTub,

        [CssClass("fa-hotdog")]
        Hotdog,

        [CssClass("fa-hotel")]
        Hotel,

        [CssClass("fa-hotjar")]
        Hotjar,

        [CssClass("fa-hourglass")]
        Hourglass,

        [CssClass("fa-hourglass-end")]
        HourglassEnd,

        [CssClass("fa-hourglass-half")]
        HourglassHalf,

        [CssClass("fa-hourglass-start")]
        HourglassStart,

        [CssClass("fa-house")]
        House,

        [CssClass("fa-house-damage")]
        HouseDamage,

        [CssClass("fa-house-day")]
        HouseDay,

        [CssClass("fa-house-flood")]
        HouseFlood,

        [CssClass("fa-house-leave")]
        HouseLeave,

        [CssClass("fa-house-night")]
        HouseNight,

        [CssClass("fa-house-return")]
        HouseReturn,

        [CssClass("fa-house-signal")]
        HouseSignal,

        [CssClass("fa-house-user")]
        HouseUser,

        [CssClass("fa-houzz")]
        Houzz,

        [CssClass("fa-hryvnia")]
        Hryvnia,

        [CssClass("fa-html5")]
        Html5,

        [CssClass("fa-hubspot")]
        Hubspot,

        [CssClass("fa-humidity")]
        Humidity,

        [CssClass("fa-hurricane")]
        Hurricane,

        [CssClass("fa-i-cursor")]
        ICursor,

        [CssClass("fa-ice-cream")]
        IceCream,

        [CssClass("fa-ice-skate")]
        IceSkate,

        [CssClass("fa-icicles")]
        Icicles,

        [CssClass("fa-icons")]
        Icons,

        [CssClass("fa-icons-alt")]
        IconsAlt,

        [CssClass("fa-id-badge")]
        IdBadge,

        [CssClass("fa-id-card")]
        IdCard,

        [CssClass("fa-id-card-alt")]
        IdCardAlt,

        [CssClass("fa-ideal")]
        Ideal,

        [CssClass("fa-igloo")]
        Igloo,

        [CssClass("fa-image")]
        Image,

        [CssClass("fa-image-polaroid")]
        ImagePolaroid,

        [CssClass("fa-images")]
        Images,

        [CssClass("fa-imdb")]
        Imdb,

        [CssClass("fa-inbox")]
        Inbox,

        [CssClass("fa-inbox-in")]
        InboxIn,

        [CssClass("fa-inbox-out")]
        InboxOut,

        [CssClass("fa-indent")]
        Indent,

        [CssClass("fa-industry")]
        Industry,

        [CssClass("fa-industry-alt")]
        IndustryAlt,

        [CssClass("fa-infinity")]
        Infinity,

        [CssClass("fa-info")]
        Info,

        [CssClass("fa-info-circle")]
        InfoCircle,

        [CssClass("fa-info-square")]
        InfoSquare,

        [CssClass("fa-inhaler")]
        Inhaler,

        [CssClass("fa-innosoft")]
        Innosoft,

        [CssClass("fa-instagram")]
        Instagram,

        [CssClass("fa-instagram-square")]
        InstagramSquare,

        [CssClass("fa-instalod")]
        Instalod,

        [CssClass("fa-integral")]
        Integral,

        [CssClass("fa-intercom")]
        Intercom,

        [CssClass("fa-internet-explorer")]
        InternetExplorer,

        [CssClass("fa-intersection")]
        Intersection,

        [CssClass("fa-inventory")]
        Inventory,

        [CssClass("fa-invision")]
        Invision,

        [CssClass("fa-ioxhost")]
        Ioxhost,

        [CssClass("fa-island-tropical")]
        IslandTropical,

        [CssClass("fa-italic")]
        Italic,

        [CssClass("fa-itch-io")]
        ItchIo,

        [CssClass("fa-itunes")]
        Itunes,

        [CssClass("fa-itunes-note")]
        ItunesNote,

        [CssClass("fa-jack-o-lantern")]
        JackOLantern,

        [CssClass("fa-java")]
        Java,

        [CssClass("fa-jedi")]
        Jedi,

        [CssClass("fa-jedi-order")]
        JediOrder,

        [CssClass("fa-jenkins")]
        Jenkins,

        [CssClass("fa-jira")]
        Jira,

        [CssClass("fa-joget")]
        Joget,

        [CssClass("fa-joint")]
        Joint,

        [CssClass("fa-joomla")]
        Joomla,

        [CssClass("fa-journal-whills")]
        JournalWhills,

        [CssClass("fa-joystick")]
        Joystick,

        [CssClass("fa-js")]
        Js,

        [CssClass("fa-js-square")]
        JsSquare,

        [CssClass("fa-jsfiddle")]
        Jsfiddle,

        [CssClass("fa-jug")]
        Jug,

        [CssClass("fa-kaaba")]
        Kaaba,

        [CssClass("fa-kaggle")]
        Kaggle,

        [CssClass("fa-kazoo")]
        Kazoo,

        [CssClass("fa-kerning")]
        Kerning,

        [CssClass("fa-key")]
        Key,

        [CssClass("fa-key-skeleton")]
        KeySkeleton,

        [CssClass("fa-keybase")]
        Keybase,

        [CssClass("fa-keyboard")]
        Keyboard,

        [CssClass("fa-keycdn")]
        Keycdn,

        [CssClass("fa-keynote")]
        Keynote,

        [CssClass("fa-khanda")]
        Khanda,

        [CssClass("fa-kickstarter")]
        Kickstarter,

        [CssClass("fa-kickstarter-k")]
        KickstarterK,

        [CssClass("fa-kidneys")]
        Kidneys,

        [CssClass("fa-kiss")]
        Kiss,

        [CssClass("fa-kiss-beam")]
        KissBeam,

        [CssClass("fa-kiss-wink-heart")]
        KissWinkHeart,

        [CssClass("fa-kite")]
        Kite,

        [CssClass("fa-kiwi-bird")]
        KiwiBird,

        [CssClass("fa-knife-kitchen")]
        KnifeKitchen,

        [CssClass("fa-korvue")]
        Korvue,

        [CssClass("fa-lambda")]
        Lambda,

        [CssClass("fa-lamp")]
        Lamp,

        [CssClass("fa-lamp-desk")]
        LampDesk,

        [CssClass("fa-lamp-floor")]
        LampFloor,

        [CssClass("fa-landmark")]
        Landmark,

        [CssClass("fa-landmark-alt")]
        LandmarkAlt,

        [CssClass("fa-language")]
        Language,

        [CssClass("fa-laptop")]
        Laptop,

        [CssClass("fa-laptop-code")]
        LaptopCode,

        [CssClass("fa-laptop-house")]
        LaptopHouse,

        [CssClass("fa-laptop-medical")]
        LaptopMedical,

        [CssClass("fa-laravel")]
        Laravel,

        [CssClass("fa-lasso")]
        Lasso,

        [CssClass("fa-lastfm")]
        Lastfm,

        [CssClass("fa-lastfm-square")]
        LastfmSquare,

        [CssClass("fa-laugh")]
        Laugh,

        [CssClass("fa-laugh-beam")]
        LaughBeam,

        [CssClass("fa-laugh-squint")]
        LaughSquint,

        [CssClass("fa-laugh-wink")]
        LaughWink,

        [CssClass("fa-layer-group")]
        LayerGroup,

        [CssClass("fa-layer-minus")]
        LayerMinus,

        [CssClass("fa-layer-plus")]
        LayerPlus,

        [CssClass("fa-leaf")]
        Leaf,

        [CssClass("fa-leaf-heart")]
        LeafHeart,

        [CssClass("fa-leaf-maple")]
        LeafMaple,

        [CssClass("fa-leaf-oak")]
        LeafOak,

        [CssClass("fa-leanpub")]
        Leanpub,

        [CssClass("fa-lemon")]
        Lemon,

        [CssClass("fa-less")]
        Less,

        [CssClass("fa-less-than")]
        LessThan,

        [CssClass("fa-less-than-equal")]
        LessThanEqual,

        [CssClass("fa-level-down")]
        LevelDown,

        [CssClass("fa-level-down-alt")]
        LevelDownAlt,

        [CssClass("fa-level-up")]
        LevelUp,

        [CssClass("fa-level-up-alt")]
        LevelUpAlt,

        [CssClass("fa-life-ring")]
        LifeRing,

        [CssClass("fa-light-ceiling")]
        LightCeiling,

        [CssClass("fa-light-switch")]
        LightSwitch,

        [CssClass("fa-light-switch-off")]
        LightSwitchOff,

        [CssClass("fa-light-switch-on")]
        LightSwitchOn,

        [CssClass("fa-lightbulb")]
        Lightbulb,

        [CssClass("fa-lightbulb-dollar")]
        LightbulbDollar,

        [CssClass("fa-lightbulb-exclamation")]
        LightbulbExclamation,

        [CssClass("fa-lightbulb-on")]
        LightbulbOn,

        [CssClass("fa-lightbulb-slash")]
        LightbulbSlash,

        [CssClass("fa-lights-holiday")]
        LightsHoliday,

        [CssClass("fa-line")]
        Line,

        [CssClass("fa-line-columns")]
        LineColumns,

        [CssClass("fa-line-height")]
        LineHeight,

        [CssClass("fa-link")]
        Link,

        [CssClass("fa-linkedin")]
        Linkedin,

        [CssClass("fa-linkedin-in")]
        LinkedinIn,

        [CssClass("fa-linode")]
        Linode,

        [CssClass("fa-linux")]
        Linux,

        [CssClass("fa-lips")]
        Lips,

        [CssClass("fa-lira-sign")]
        LiraSign,

        [CssClass("fa-list")]
        List,

        [CssClass("fa-list-alt")]
        ListAlt,

        [CssClass("fa-list-music")]
        ListMusic,

        [CssClass("fa-list-ol")]
        ListOl,

        [CssClass("fa-list-ul")]
        ListUl,

        [CssClass("fa-location")]
        Location,

        [CssClass("fa-location-arrow")]
        LocationArrow,

        [CssClass("fa-location-circle")]
        LocationCircle,

        [CssClass("fa-location-slash")]
        LocationSlash,

        [CssClass("fa-lock")]
        Lock,

        [CssClass("fa-lock-alt")]
        LockAlt,

        [CssClass("fa-lock-open")]
        LockOpen,

        [CssClass("fa-lock-open-alt")]
        LockOpenAlt,

        [CssClass("fa-long-arrow-alt-down")]
        LongArrowAltDown,

        [CssClass("fa-long-arrow-alt-left")]
        LongArrowAltLeft,

        [CssClass("fa-long-arrow-alt-right")]
        LongArrowAltRight,

        [CssClass("fa-long-arrow-alt-up")]
        LongArrowAltUp,

        [CssClass("fa-long-arrow-down")]
        LongArrowDown,

        [CssClass("fa-long-arrow-left")]
        LongArrowLeft,

        [CssClass("fa-long-arrow-right")]
        LongArrowRight,

        [CssClass("fa-long-arrow-up")]
        LongArrowUp,

        [CssClass("fa-loveseat")]
        Loveseat,

        [CssClass("fa-low-vision")]
        LowVision,

        [CssClass("fa-luchador")]
        Luchador,

        [CssClass("fa-luggage-cart")]
        LuggageCart,

        [CssClass("fa-lungs")]
        Lungs,

        [CssClass("fa-lungs-virus")]
        LungsVirus,

        [CssClass("fa-lyft")]
        Lyft,

        [CssClass("fa-mace")]
        Mace,

        [CssClass("fa-magento")]
        Magento,

        [CssClass("fa-magic")]
        Magic,

        [CssClass("fa-magnet")]
        Magnet,

        [CssClass("fa-mail-bulk")]
        MailBulk,

        [CssClass("fa-mailbox")]
        Mailbox,

        [CssClass("fa-mailchimp")]
        Mailchimp,

        [CssClass("fa-male")]
        Male,

        [CssClass("fa-mandalorian")]
        Mandalorian,

        [CssClass("fa-mandolin")]
        Mandolin,

        [CssClass("fa-map")]
        Map,

        [CssClass("fa-map-marked")]
        MapMarked,

        [CssClass("fa-map-marked-alt")]
        MapMarkedAlt,

        [CssClass("fa-map-marker")]
        MapMarker,

        [CssClass("fa-map-marker-alt")]
        MapMarkerAlt,

        [CssClass("fa-map-marker-alt-slash")]
        MapMarkerAltSlash,

        [CssClass("fa-map-marker-check")]
        MapMarkerCheck,

        [CssClass("fa-map-marker-edit")]
        MapMarkerEdit,

        [CssClass("fa-map-marker-exclamation")]
        MapMarkerExclamation,

        [CssClass("fa-map-marker-minus")]
        MapMarkerMinus,

        [CssClass("fa-map-marker-plus")]
        MapMarkerPlus,

        [CssClass("fa-map-marker-question")]
        MapMarkerQuestion,

        [CssClass("fa-map-marker-slash")]
        MapMarkerSlash,

        [CssClass("fa-map-marker-smile")]
        MapMarkerSmile,

        [CssClass("fa-map-marker-times")]
        MapMarkerTimes,

        [CssClass("fa-map-pin")]
        MapPin,

        [CssClass("fa-map-signs")]
        MapSigns,

        [CssClass("fa-markdown")]
        Markdown,

        [CssClass("fa-marker")]
        Marker,

        [CssClass("fa-mars")]
        Mars,

        [CssClass("fa-mars-double")]
        MarsDouble,

        [CssClass("fa-mars-stroke")]
        MarsStroke,

        [CssClass("fa-mars-stroke-h")]
        MarsStrokeH,

        [CssClass("fa-mars-stroke-v")]
        MarsStrokeV,

        [CssClass("fa-mask")]
        Mask,

        [CssClass("fa-mastodon")]
        Mastodon,

        [CssClass("fa-maxcdn")]
        Maxcdn,

        [CssClass("fa-mdb")]
        Mdb,

        [CssClass("fa-meat")]
        Meat,

        [CssClass("fa-medal")]
        Medal,

        [CssClass("fa-medapps")]
        Medapps,

        [CssClass("fa-medium")]
        Medium,

        [CssClass("fa-medium-m")]
        MediumM,

        [CssClass("fa-medkit")]
        Medkit,

        [CssClass("fa-medrt")]
        Medrt,

        [CssClass("fa-meetup")]
        Meetup,

        [CssClass("fa-megaphone")]
        Megaphone,

        [CssClass("fa-megaport")]
        Megaport,

        [CssClass("fa-meh")]
        Meh,

        [CssClass("fa-meh-blank")]
        MehBlank,

        [CssClass("fa-meh-rolling-eyes")]
        MehRollingEyes,

        [CssClass("fa-memory")]
        Memory,

        [CssClass("fa-mendeley")]
        Mendeley,

        [CssClass("fa-menorah")]
        Menorah,

        [CssClass("fa-mercury")]
        Mercury,

        [CssClass("fa-meteor")]
        Meteor,

        [CssClass("fa-microblog")]
        Microblog,

        [CssClass("fa-microchip")]
        Microchip,

        [CssClass("fa-microphone")]
        Microphone,

        [CssClass("fa-microphone-alt")]
        MicrophoneAlt,

        [CssClass("fa-microphone-alt-slash")]
        MicrophoneAltSlash,

        [CssClass("fa-microphone-slash")]
        MicrophoneSlash,

        [CssClass("fa-microphone-stand")]
        MicrophoneStand,

        [CssClass("fa-microscope")]
        Microscope,

        [CssClass("fa-microsoft")]
        Microsoft,

        [CssClass("fa-microwave")]
        Microwave,

        [CssClass("fa-mind-share")]
        MindShare,

        [CssClass("fa-minus")]
        Minus,

        [CssClass("fa-minus-circle")]
        MinusCircle,

        [CssClass("fa-minus-hexagon")]
        MinusHexagon,

        [CssClass("fa-minus-octagon")]
        MinusOctagon,

        [CssClass("fa-minus-square")]
        MinusSquare,

        [CssClass("fa-mistletoe")]
        Mistletoe,

        [CssClass("fa-mitten")]
        Mitten,

        [CssClass("fa-mix")]
        Mix,

        [CssClass("fa-mixcloud")]
        Mixcloud,

        [CssClass("fa-mixer")]
        Mixer,

        [CssClass("fa-mizuni")]
        Mizuni,

        [CssClass("fa-mobile")]
        Mobile,

        [CssClass("fa-mobile-alt")]
        MobileAlt,

        [CssClass("fa-mobile-android")]
        MobileAndroid,

        [CssClass("fa-mobile-android-alt")]
        MobileAndroidAlt,

        [CssClass("fa-modx")]
        Modx,

        [CssClass("fa-monero")]
        Monero,

        [CssClass("fa-money-bill")]
        MoneyBill,

        [CssClass("fa-money-bill-alt")]
        MoneyBillAlt,

        [CssClass("fa-money-bill-wave")]
        MoneyBillWave,

        [CssClass("fa-money-bill-wave-alt")]
        MoneyBillWaveAlt,

        [CssClass("fa-money-check")]
        MoneyCheck,

        [CssClass("fa-money-check-alt")]
        MoneyCheckAlt,

        [CssClass("fa-money-check-edit")]
        MoneyCheckEdit,

        [CssClass("fa-money-check-edit-alt")]
        MoneyCheckEditAlt,

        [CssClass("fa-monitor-heart-rate")]
        MonitorHeartRate,

        [CssClass("fa-monkey")]
        Monkey,

        [CssClass("fa-monument")]
        Monument,

        [CssClass("fa-moon")]
        Moon,

        [CssClass("fa-moon-cloud")]
        MoonCloud,

        [CssClass("fa-moon-stars")]
        MoonStars,

        [CssClass("fa-mortar-pestle")]
        MortarPestle,

        [CssClass("fa-mosque")]
        Mosque,

        [CssClass("fa-motorcycle")]
        Motorcycle,

        [CssClass("fa-mountain")]
        Mountain,

        [CssClass("fa-mountains")]
        Mountains,

        [CssClass("fa-mouse")]
        Mouse,

        [CssClass("fa-mouse-alt")]
        MouseAlt,

        [CssClass("fa-mouse-pointer")]
        MousePointer,

        [CssClass("fa-mp3-player")]
        Mp3Player,

        [CssClass("fa-mug")]
        Mug,

        [CssClass("fa-mug-hot")]
        MugHot,

        [CssClass("fa-mug-marshmallows")]
        MugMarshmallows,

        [CssClass("fa-mug-tea")]
        MugTea,

        [CssClass("fa-music")]
        Music,

        [CssClass("fa-music-alt")]
        MusicAlt,

        [CssClass("fa-music-alt-slash")]
        MusicAltSlash,

        [CssClass("fa-music-slash")]
        MusicSlash,

        [CssClass("fa-napster")]
        Napster,

        [CssClass("fa-narwhal")]
        Narwhal,

        [CssClass("fa-neos")]
        Neos,

        [CssClass("fa-network-wired")]
        NetworkWired,

        [CssClass("fa-neuter")]
        Neuter,

        [CssClass("fa-newspaper")]
        Newspaper,

        [CssClass("fa-nimblr")]
        Nimblr,

        [CssClass("fa-node")]
        Node,

        [CssClass("fa-node-js")]
        NodeJs,

        [CssClass("fa-not-equal")]
        NotEqual,

        [CssClass("fa-notes-medical")]
        NotesMedical,

        [CssClass("fa-npm")]
        Npm,

        [CssClass("fa-ns8")]
        Ns8,

        [CssClass("fa-nutritionix")]
        Nutritionix,

        [CssClass("fa-object-group")]
        ObjectGroup,

        [CssClass("fa-object-ungroup")]
        ObjectUngroup,

        [CssClass("fa-octagon")]
        Octagon,

        [CssClass("fa-octopus-deploy")]
        OctopusDeploy,

        [CssClass("fa-odnoklassniki")]
        Odnoklassniki,

        [CssClass("fa-odnoklassniki-square")]
        OdnoklassnikiSquare,

        [CssClass("fa-oil-can")]
        OilCan,

        [CssClass("fa-oil-temp")]
        OilTemp,

        [CssClass("fa-old-republic")]
        OldRepublic,

        [CssClass("fa-om")]
        Om,

        [CssClass("fa-omega")]
        Omega,

        [CssClass("fa-opencart")]
        Opencart,

        [CssClass("fa-openid")]
        Openid,

        [CssClass("fa-opera")]
        Opera,

        [CssClass("fa-optin-monster")]
        OptinMonster,

        [CssClass("fa-orcid")]
        Orcid,

        [CssClass("fa-ornament")]
        Ornament,

        [CssClass("fa-osi")]
        Osi,

        [CssClass("fa-otter")]
        Otter,

        [CssClass("fa-outdent")]
        Outdent,

        [CssClass("fa-outlet")]
        Outlet,

        [CssClass("fa-oven")]
        Oven,

        [CssClass("fa-overline")]
        Overline,

        [CssClass("fa-page-break")]
        PageBreak,

        [CssClass("fa-page4")]
        Page4,

        [CssClass("fa-pagelines")]
        Pagelines,

        [CssClass("fa-pager")]
        Pager,

        [CssClass("fa-paint-brush")]
        PaintBrush,

        [CssClass("fa-paint-brush-alt")]
        PaintBrushAlt,

        [CssClass("fa-paint-roller")]
        PaintRoller,

        [CssClass("fa-palette")]
        Palette,

        [CssClass("fa-palfed")]
        Palfed,

        [CssClass("fa-pallet")]
        Pallet,

        [CssClass("fa-pallet-alt")]
        PalletAlt,

        [CssClass("fa-paper-plane")]
        PaperPlane,

        [CssClass("fa-paperclip")]
        Paperclip,

        [CssClass("fa-parachute-box")]
        ParachuteBox,

        [CssClass("fa-paragraph")]
        Paragraph,

        [CssClass("fa-paragraph-rtl")]
        ParagraphRtl,

        [CssClass("fa-parking")]
        Parking,

        [CssClass("fa-parking-circle")]
        ParkingCircle,

        [CssClass("fa-parking-circle-slash")]
        ParkingCircleSlash,

        [CssClass("fa-parking-slash")]
        ParkingSlash,

        [CssClass("fa-passport")]
        Passport,

        [CssClass("fa-pastafarianism")]
        Pastafarianism,

        [CssClass("fa-paste")]
        Paste,

        [CssClass("fa-patreon")]
        Patreon,

        [CssClass("fa-pause")]
        Pause,

        [CssClass("fa-pause-circle")]
        PauseCircle,

        [CssClass("fa-paw")]
        Paw,

        [CssClass("fa-paw-alt")]
        PawAlt,

        [CssClass("fa-paw-claws")]
        PawClaws,

        [CssClass("fa-paypal")]
        Paypal,

        [CssClass("fa-peace")]
        Peace,

        [CssClass("fa-pegasus")]
        Pegasus,

        [CssClass("fa-pen")]
        Pen,

        [CssClass("fa-pen-alt")]
        PenAlt,

        [CssClass("fa-pen-fancy")]
        PenFancy,

        [CssClass("fa-pen-nib")]
        PenNib,

        [CssClass("fa-pen-square")]
        PenSquare,

        [CssClass("fa-pencil")]
        Pencil,

        [CssClass("fa-pencil-alt")]
        PencilAlt,

        [CssClass("fa-pencil-paintbrush")]
        PencilPaintbrush,

        [CssClass("fa-pencil-ruler")]
        PencilRuler,

        [CssClass("fa-pennant")]
        Pennant,

        [CssClass("fa-penny-arcade")]
        PennyArcade,

        [CssClass("fa-people-arrows")]
        PeopleArrows,

        [CssClass("fa-people-carry")]
        PeopleCarry,

        [CssClass("fa-pepper-hot")]
        PepperHot,

        [CssClass("fa-perbyte")]
        Perbyte,

        [CssClass("fa-percent")]
        Percent,

        [CssClass("fa-percentage")]
        Percentage,

        [CssClass("fa-periscope")]
        Periscope,

        [CssClass("fa-person-booth")]
        PersonBooth,

        [CssClass("fa-person-carry")]
        PersonCarry,

        [CssClass("fa-person-dolly")]
        PersonDolly,

        [CssClass("fa-person-dolly-empty")]
        PersonDollyEmpty,

        [CssClass("fa-person-sign")]
        PersonSign,

        [CssClass("fa-phabricator")]
        Phabricator,

        [CssClass("fa-phoenix-framework")]
        PhoenixFramework,

        [CssClass("fa-phoenix-squadron")]
        PhoenixSquadron,

        [CssClass("fa-phone")]
        Phone,

        [CssClass("fa-phone-alt")]
        PhoneAlt,

        [CssClass("fa-phone-laptop")]
        PhoneLaptop,

        [CssClass("fa-phone-office")]
        PhoneOffice,

        [CssClass("fa-phone-plus")]
        PhonePlus,

        [CssClass("fa-phone-rotary")]
        PhoneRotary,

        [CssClass("fa-phone-slash")]
        PhoneSlash,

        [CssClass("fa-phone-square")]
        PhoneSquare,

        [CssClass("fa-phone-square-alt")]
        PhoneSquareAlt,

        [CssClass("fa-phone-volume")]
        PhoneVolume,

        [CssClass("fa-photo-video")]
        PhotoVideo,

        [CssClass("fa-php")]
        Php,

        [CssClass("fa-pi")]
        Pi,

        [CssClass("fa-piano")]
        Piano,

        [CssClass("fa-piano-keyboard")]
        PianoKeyboard,

        [CssClass("fa-pie")]
        Pie,

        [CssClass("fa-pied-piper")]
        PiedPiper,

        [CssClass("fa-pied-piper-alt")]
        PiedPiperAlt,

        [CssClass("fa-pied-piper-hat")]
        PiedPiperHat,

        [CssClass("fa-pied-piper-pp")]
        PiedPiperPp,

        [CssClass("fa-pied-piper-square")]
        PiedPiperSquare,

        [CssClass("fa-pig")]
        Pig,

        [CssClass("fa-piggy-bank")]
        PiggyBank,

        [CssClass("fa-pills")]
        Pills,

        [CssClass("fa-pinterest")]
        Pinterest,

        [CssClass("fa-pinterest-p")]
        PinterestP,

        [CssClass("fa-pinterest-square")]
        PinterestSquare,

        [CssClass("fa-pizza")]
        Pizza,

        [CssClass("fa-pizza-slice")]
        PizzaSlice,

        [CssClass("fa-place-of-worship")]
        PlaceOfWorship,

        [CssClass("fa-plane")]
        Plane,

        [CssClass("fa-plane-alt")]
        PlaneAlt,

        [CssClass("fa-plane-arrival")]
        PlaneArrival,

        [CssClass("fa-plane-departure")]
        PlaneDeparture,

        [CssClass("fa-plane-slash")]
        PlaneSlash,

        [CssClass("fa-planet-moon")]
        PlanetMoon,

        [CssClass("fa-planet-ringed")]
        PlanetRinged,

        [CssClass("fa-play")]
        Play,

        [CssClass("fa-play-circle")]
        PlayCircle,

        [CssClass("fa-playstation")]
        Playstation,

        [CssClass("fa-plug")]
        Plug,

        [CssClass("fa-plus")]
        Plus,

        [CssClass("fa-plus-circle")]
        PlusCircle,

        [CssClass("fa-plus-hexagon")]
        PlusHexagon,

        [CssClass("fa-plus-octagon")]
        PlusOctagon,

        [CssClass("fa-plus-square")]
        PlusSquare,

        [CssClass("fa-podcast")]
        Podcast,

        [CssClass("fa-podium")]
        Podium,

        [CssClass("fa-podium-star")]
        PodiumStar,

        [CssClass("fa-police-box")]
        PoliceBox,

        [CssClass("fa-poll")]
        Poll,

        [CssClass("fa-poll-h")]
        PollH,

        [CssClass("fa-poll-people")]
        PollPeople,

        [CssClass("fa-poo")]
        Poo,

        [CssClass("fa-poo-storm")]
        PooStorm,

        [CssClass("fa-poop")]
        Poop,

        [CssClass("fa-popcorn")]
        Popcorn,

        [CssClass("fa-portal-enter")]
        PortalEnter,

        [CssClass("fa-portal-exit")]
        PortalExit,

        [CssClass("fa-portrait")]
        Portrait,

        [CssClass("fa-pound-sign")]
        PoundSign,

        [CssClass("fa-power-off")]
        PowerOff,

        [CssClass("fa-pray")]
        Pray,

        [CssClass("fa-praying-hands")]
        PrayingHands,

        [CssClass("fa-prescription")]
        Prescription,

        [CssClass("fa-prescription-bottle")]
        PrescriptionBottle,

        [CssClass("fa-prescription-bottle-alt")]
        PrescriptionBottleAlt,

        [CssClass("fa-presentation")]
        Presentation,

        [CssClass("fa-print")]
        Print,

        [CssClass("fa-print-search")]
        PrintSearch,

        [CssClass("fa-print-slash")]
        PrintSlash,

        [CssClass("fa-procedures")]
        Procedures,

        [CssClass("fa-product-hunt")]
        ProductHunt,

        [CssClass("fa-project-diagram")]
        ProjectDiagram,

        [CssClass("fa-projector")]
        Projector,

        [CssClass("fa-pump-medical")]
        PumpMedical,

        [CssClass("fa-pump-soap")]
        PumpSoap,

        [CssClass("fa-pumpkin")]
        Pumpkin,

        [CssClass("fa-pushed")]
        Pushed,

        [CssClass("fa-puzzle-piece")]
        PuzzlePiece,

        [CssClass("fa-python")]
        Python,

        [CssClass("fa-qq")]
        Qq,

        [CssClass("fa-qrcode")]
        Qrcode,

        [CssClass("fa-question")]
        Question,

        [CssClass("fa-question-circle")]
        QuestionCircle,

        [CssClass("fa-question-square")]
        QuestionSquare,

        [CssClass("fa-quidditch")]
        Quidditch,

        [CssClass("fa-quinscape")]
        Quinscape,

        [CssClass("fa-quora")]
        Quora,

        [CssClass("fa-quote-left")]
        QuoteLeft,

        [CssClass("fa-quote-right")]
        QuoteRight,

        [CssClass("fa-quran")]
        Quran,

        [CssClass("fa-r-project")]
        RProject,

        [CssClass("fa-rabbit")]
        Rabbit,

        [CssClass("fa-rabbit-fast")]
        RabbitFast,

        [CssClass("fa-racquet")]
        Racquet,

        [CssClass("fa-radar")]
        Radar,

        [CssClass("fa-radiation")]
        Radiation,

        [CssClass("fa-radiation-alt")]
        RadiationAlt,

        [CssClass("fa-radio")]
        Radio,

        [CssClass("fa-radio-alt")]
        RadioAlt,

        [CssClass("fa-rainbow")]
        Rainbow,

        [CssClass("fa-raindrops")]
        Raindrops,

        [CssClass("fa-ram")]
        Ram,

        [CssClass("fa-ramp-loading")]
        RampLoading,

        [CssClass("fa-random")]
        Random,

        [CssClass("fa-raspberry-pi")]
        RaspberryPi,

        [CssClass("fa-ravelry")]
        Ravelry,

        [CssClass("fa-raygun")]
        Raygun,

        [CssClass("fa-react")]
        React,

        [CssClass("fa-reacteurope")]
        Reacteurope,

        [CssClass("fa-readme")]
        Readme,

        [CssClass("fa-rebel")]
        Rebel,

        [CssClass("fa-receipt")]
        Receipt,

        [CssClass("fa-record-vinyl")]
        RecordVinyl,

        [CssClass("fa-rectangle-landscape")]
        RectangleLandscape,

        [CssClass("fa-rectangle-portrait")]
        RectanglePortrait,

        [CssClass("fa-rectangle-wide")]
        RectangleWide,

        [CssClass("fa-recycle")]
        Recycle,

        [CssClass("fa-red-river")]
        RedRiver,

        [CssClass("fa-reddit")]
        Reddit,

        [CssClass("fa-reddit-alien")]
        RedditAlien,

        [CssClass("fa-reddit-square")]
        RedditSquare,

        [CssClass("fa-redhat")]
        Redhat,

        [CssClass("fa-redo")]
        Redo,

        [CssClass("fa-redo-alt")]
        RedoAlt,

        [CssClass("fa-refrigerator")]
        Refrigerator,

        [CssClass("fa-registered")]
        Registered,

        [CssClass("fa-remove-format")]
        RemoveFormat,

        [CssClass("fa-renren")]
        Renren,

        [CssClass("fa-repeat")]
        Repeat,

        [CssClass("fa-repeat-1")]
        Repeat1,

        [CssClass("fa-repeat-1-alt")]
        Repeat1Alt,

        [CssClass("fa-repeat-alt")]
        RepeatAlt,

        [CssClass("fa-reply")]
        Reply,

        [CssClass("fa-reply-all")]
        ReplyAll,

        [CssClass("fa-replyd")]
        Replyd,

        [CssClass("fa-republican")]
        Republican,

        [CssClass("fa-researchgate")]
        Researchgate,

        [CssClass("fa-resolving")]
        Resolving,

        [CssClass("fa-restroom")]
        Restroom,

        [CssClass("fa-retweet")]
        Retweet,

        [CssClass("fa-retweet-alt")]
        RetweetAlt,

        [CssClass("fa-rev")]
        Rev,

        [CssClass("fa-ribbon")]
        Ribbon,

        [CssClass("fa-ring")]
        Ring,

        [CssClass("fa-rings-wedding")]
        RingsWedding,

        [CssClass("fa-road")]
        Road,

        [CssClass("fa-robot")]
        Robot,

        [CssClass("fa-rocket")]
        Rocket,

        [CssClass("fa-rocket-launch")]
        RocketLaunch,

        [CssClass("fa-rocketchat")]
        Rocketchat,

        [CssClass("fa-rockrms")]
        Rockrms,

        [CssClass("fa-route")]
        Route,

        [CssClass("fa-route-highway")]
        RouteHighway,

        [CssClass("fa-route-interstate")]
        RouteInterstate,

        [CssClass("fa-router")]
        Router,

        [CssClass("fa-rss")]
        Rss,

        [CssClass("fa-rss-square")]
        RssSquare,

        [CssClass("fa-ruble-sign")]
        RubleSign,

        [CssClass("fa-ruler")]
        Ruler,

        [CssClass("fa-ruler-combined")]
        RulerCombined,

        [CssClass("fa-ruler-horizontal")]
        RulerHorizontal,

        [CssClass("fa-ruler-triangle")]
        RulerTriangle,

        [CssClass("fa-ruler-vertical")]
        RulerVertical,

        [CssClass("fa-running")]
        Running,

        [CssClass("fa-rupee-sign")]
        RupeeSign,

        [CssClass("fa-rust")]
        Rust,

        [CssClass("fa-rv")]
        Rv,

        [CssClass("fa-sack")]
        Sack,

        [CssClass("fa-sack-dollar")]
        SackDollar,

        [CssClass("fa-sad-cry")]
        SadCry,

        [CssClass("fa-sad-tear")]
        SadTear,

        [CssClass("fa-safari")]
        Safari,

        [CssClass("fa-salad")]
        Salad,

        [CssClass("fa-salesforce")]
        Salesforce,

        [CssClass("fa-sandwich")]
        Sandwich,

        [CssClass("fa-sass")]
        Sass,

        [CssClass("fa-satellite")]
        Satellite,

        [CssClass("fa-satellite-dish")]
        SatelliteDish,

        [CssClass("fa-sausage")]
        Sausage,

        [CssClass("fa-save")]
        Save,

        [CssClass("fa-sax-hot")]
        SaxHot,

        [CssClass("fa-saxophone")]
        Saxophone,

        [CssClass("fa-scalpel")]
        Scalpel,

        [CssClass("fa-scalpel-path")]
        ScalpelPath,

        [CssClass("fa-scanner")]
        Scanner,

        [CssClass("fa-scanner-image")]
        ScannerImage,

        [CssClass("fa-scanner-keyboard")]
        ScannerKeyboard,

        [CssClass("fa-scanner-touchscreen")]
        ScannerTouchscreen,

        [CssClass("fa-scarecrow")]
        Scarecrow,

        [CssClass("fa-scarf")]
        Scarf,

        [CssClass("fa-schlix")]
        Schlix,

        [CssClass("fa-school")]
        School,

        [CssClass("fa-screwdriver")]
        Screwdriver,

        [CssClass("fa-scribd")]
        Scribd,

        [CssClass("fa-scroll")]
        Scroll,

        [CssClass("fa-scroll-old")]
        ScrollOld,

        [CssClass("fa-scrubber")]
        Scrubber,

        [CssClass("fa-scythe")]
        Scythe,

        [CssClass("fa-sd-card")]
        SdCard,

        [CssClass("fa-search")]
        Search,

        [CssClass("fa-search-dollar")]
        SearchDollar,

        [CssClass("fa-search-location")]
        SearchLocation,

        [CssClass("fa-search-minus")]
        SearchMinus,

        [CssClass("fa-search-plus")]
        SearchPlus,

        [CssClass("fa-searchengin")]
        Searchengin,

        [CssClass("fa-seedling")]
        Seedling,

        [CssClass("fa-sellcast")]
        Sellcast,

        [CssClass("fa-sellsy")]
        Sellsy,

        [CssClass("fa-send-back")]
        SendBack,

        [CssClass("fa-send-backward")]
        SendBackward,

        [CssClass("fa-sensor")]
        Sensor,

        [CssClass("fa-sensor-alert")]
        SensorAlert,

        [CssClass("fa-sensor-fire")]
        SensorFire,

        [CssClass("fa-sensor-on")]
        SensorOn,

        [CssClass("fa-sensor-smoke")]
        SensorSmoke,

        [CssClass("fa-server")]
        Server,

        [CssClass("fa-servicestack")]
        Servicestack,

        [CssClass("fa-shapes")]
        Shapes,

        [CssClass("fa-share")]
        Share,

        [CssClass("fa-share-all")]
        ShareAll,

        [CssClass("fa-share-alt")]
        ShareAlt,

        [CssClass("fa-share-alt-square")]
        ShareAltSquare,

        [CssClass("fa-share-square")]
        ShareSquare,

        [CssClass("fa-sheep")]
        Sheep,

        [CssClass("fa-shekel-sign")]
        ShekelSign,

        [CssClass("fa-shield")]
        Shield,

        [CssClass("fa-shield-alt")]
        ShieldAlt,

        [CssClass("fa-shield-check")]
        ShieldCheck,

        [CssClass("fa-shield-cross")]
        ShieldCross,

        [CssClass("fa-shield-virus")]
        ShieldVirus,

        [CssClass("fa-ship")]
        Ship,

        [CssClass("fa-shipping-fast")]
        ShippingFast,

        [CssClass("fa-shipping-timed")]
        ShippingTimed,

        [CssClass("fa-shirtsinbulk")]
        Shirtsinbulk,

        [CssClass("fa-shish-kebab")]
        ShishKebab,

        [CssClass("fa-shoe-prints")]
        ShoePrints,

        [CssClass("fa-shopify")]
        Shopify,

        [CssClass("fa-shopping-bag")]
        ShoppingBag,

        [CssClass("fa-shopping-basket")]
        ShoppingBasket,

        [CssClass("fa-shopping-cart")]
        ShoppingCart,

        [CssClass("fa-shopware")]
        Shopware,

        [CssClass("fa-shovel")]
        Shovel,

        [CssClass("fa-shovel-snow")]
        ShovelSnow,

        [CssClass("fa-shower")]
        Shower,

        [CssClass("fa-shredder")]
        Shredder,

        [CssClass("fa-shuttle-van")]
        ShuttleVan,

        [CssClass("fa-shuttlecock")]
        Shuttlecock,

        [CssClass("fa-sickle")]
        Sickle,

        [CssClass("fa-sigma")]
        Sigma,

        [CssClass("fa-sign")]
        Sign,

        [CssClass("fa-sign-in")]
        SignIn,

        [CssClass("fa-sign-in-alt")]
        SignInAlt,

        [CssClass("fa-sign-language")]
        SignLanguage,

        [CssClass("fa-sign-out")]
        SignOut,

        [CssClass("fa-sign-out-alt")]
        SignOutAlt,

        [CssClass("fa-signal")]
        Signal,

        [CssClass("fa-signal-1")]
        Signal1,

        [CssClass("fa-signal-2")]
        Signal2,

        [CssClass("fa-signal-3")]
        Signal3,

        [CssClass("fa-signal-4")]
        Signal4,

        [CssClass("fa-signal-alt")]
        SignalAlt,

        [CssClass("fa-signal-alt-1")]
        SignalAlt1,

        [CssClass("fa-signal-alt-2")]
        SignalAlt2,

        [CssClass("fa-signal-alt-3")]
        SignalAlt3,

        [CssClass("fa-signal-alt-slash")]
        SignalAltSlash,

        [CssClass("fa-signal-slash")]
        SignalSlash,

        [CssClass("fa-signal-stream")]
        SignalStream,

        [CssClass("fa-signature")]
        Signature,

        [CssClass("fa-sim-card")]
        SimCard,

        [CssClass("fa-simplybuilt")]
        Simplybuilt,

        [CssClass("fa-sink")]
        Sink,

        [CssClass("fa-siren")]
        Siren,

        [CssClass("fa-siren-on")]
        SirenOn,

        [CssClass("fa-sistrix")]
        Sistrix,

        [CssClass("fa-sitemap")]
        Sitemap,

        [CssClass("fa-sith")]
        Sith,

        [CssClass("fa-skating")]
        Skating,

        [CssClass("fa-skeleton")]
        Skeleton,

        [CssClass("fa-sketch")]
        Sketch,

        [CssClass("fa-ski-jump")]
        SkiJump,

        [CssClass("fa-ski-lift")]
        SkiLift,

        [CssClass("fa-skiing")]
        Skiing,

        [CssClass("fa-skiing-nordic")]
        SkiingNordic,

        [CssClass("fa-skull")]
        Skull,

        [CssClass("fa-skull-cow")]
        SkullCow,

        [CssClass("fa-skull-crossbones")]
        SkullCrossbones,

        [CssClass("fa-skyatlas")]
        Skyatlas,

        [CssClass("fa-skype")]
        Skype,

        [CssClass("fa-slack")]
        Slack,

        [CssClass("fa-slack-hash")]
        SlackHash,

        [CssClass("fa-slash")]
        Slash,

        [CssClass("fa-sledding")]
        Sledding,

        [CssClass("fa-sleigh")]
        Sleigh,

        [CssClass("fa-sliders-h")]
        SlidersH,

        [CssClass("fa-sliders-h-square")]
        SlidersHSquare,

        [CssClass("fa-sliders-v")]
        SlidersV,

        [CssClass("fa-sliders-v-square")]
        SlidersVSquare,

        [CssClass("fa-slideshare")]
        Slideshare,

        [CssClass("fa-smile")]
        Smile,

        [CssClass("fa-smile-beam")]
        SmileBeam,

        [CssClass("fa-smile-plus")]
        SmilePlus,

        [CssClass("fa-smile-wink")]
        SmileWink,

        [CssClass("fa-smog")]
        Smog,

        [CssClass("fa-smoke")]
        Smoke,

        [CssClass("fa-smoking")]
        Smoking,

        [CssClass("fa-smoking-ban")]
        SmokingBan,

        [CssClass("fa-sms")]
        Sms,

        [CssClass("fa-snake")]
        Snake,

        [CssClass("fa-snapchat")]
        Snapchat,

        [CssClass("fa-snapchat-ghost")]
        SnapchatGhost,

        [CssClass("fa-snapchat-square")]
        SnapchatSquare,

        [CssClass("fa-snooze")]
        Snooze,

        [CssClass("fa-snow-blowing")]
        SnowBlowing,

        [CssClass("fa-snowboarding")]
        Snowboarding,

        [CssClass("fa-snowflake")]
        Snowflake,

        [CssClass("fa-snowflakes")]
        Snowflakes,

        [CssClass("fa-snowman")]
        Snowman,

        [CssClass("fa-snowmobile")]
        Snowmobile,

        [CssClass("fa-snowplow")]
        Snowplow,

        [CssClass("fa-soap")]
        Soap,

        [CssClass("fa-socks")]
        Socks,

        [CssClass("fa-solar-panel")]
        SolarPanel,

        [CssClass("fa-solar-system")]
        SolarSystem,

        [CssClass("fa-sort")]
        Sort,

        [CssClass("fa-sort-alpha-down")]
        SortAlphaDown,

        [CssClass("fa-sort-alpha-down-alt")]
        SortAlphaDownAlt,

        [CssClass("fa-sort-alpha-up")]
        SortAlphaUp,

        [CssClass("fa-sort-alpha-up-alt")]
        SortAlphaUpAlt,

        [CssClass("fa-sort-alt")]
        SortAlt,

        [CssClass("fa-sort-amount-down")]
        SortAmountDown,

        [CssClass("fa-sort-amount-down-alt")]
        SortAmountDownAlt,

        [CssClass("fa-sort-amount-up")]
        SortAmountUp,

        [CssClass("fa-sort-amount-up-alt")]
        SortAmountUpAlt,

        [CssClass("fa-sort-circle")]
        SortCircle,

        [CssClass("fa-sort-circle-down")]
        SortCircleDown,

        [CssClass("fa-sort-circle-up")]
        SortCircleUp,

        [CssClass("fa-sort-down")]
        SortDown,

        [CssClass("fa-sort-numeric-down")]
        SortNumericDown,

        [CssClass("fa-sort-numeric-down-alt")]
        SortNumericDownAlt,

        [CssClass("fa-sort-numeric-up")]
        SortNumericUp,

        [CssClass("fa-sort-numeric-up-alt")]
        SortNumericUpAlt,

        [CssClass("fa-sort-shapes-down")]
        SortShapesDown,

        [CssClass("fa-sort-shapes-down-alt")]
        SortShapesDownAlt,

        [CssClass("fa-sort-shapes-up")]
        SortShapesUp,

        [CssClass("fa-sort-shapes-up-alt")]
        SortShapesUpAlt,

        [CssClass("fa-sort-size-down")]
        SortSizeDown,

        [CssClass("fa-sort-size-down-alt")]
        SortSizeDownAlt,

        [CssClass("fa-sort-size-up")]
        SortSizeUp,

        [CssClass("fa-sort-size-up-alt")]
        SortSizeUpAlt,

        [CssClass("fa-sort-up")]
        SortUp,

        [CssClass("fa-soundcloud")]
        Soundcloud,

        [CssClass("fa-soup")]
        Soup,

        [CssClass("fa-sourcetree")]
        Sourcetree,

        [CssClass("fa-spa")]
        Spa,

        [CssClass("fa-space-shuttle")]
        SpaceShuttle,

        [CssClass("fa-space-station-moon")]
        SpaceStationMoon,

        [CssClass("fa-space-station-moon-alt")]
        SpaceStationMoonAlt,

        [CssClass("fa-spade")]
        Spade,

        [CssClass("fa-sparkles")]
        Sparkles,

        [CssClass("fa-speakap")]
        Speakap,

        [CssClass("fa-speaker")]
        Speaker,

        [CssClass("fa-speaker-deck")]
        SpeakerDeck,

        [CssClass("fa-speakers")]
        Speakers,

        [CssClass("fa-spell-check")]
        SpellCheck,

        [CssClass("fa-spider")]
        Spider,

        [CssClass("fa-spider-black-widow")]
        SpiderBlackWidow,

        [CssClass("fa-spider-web")]
        SpiderWeb,

        [CssClass("fa-spinner")]
        Spinner,

        [CssClass("fa-spinner-third")]
        SpinnerThird,

        [CssClass("fa-splotch")]
        Splotch,

        [CssClass("fa-spotify")]
        Spotify,

        [CssClass("fa-spray-can")]
        SprayCan,

        [CssClass("fa-sprinkler")]
        Sprinkler,

        [CssClass("fa-square")]
        Square,

        [CssClass("fa-square-full")]
        SquareFull,

        [CssClass("fa-square-root")]
        SquareRoot,

        [CssClass("fa-square-root-alt")]
        SquareRootAlt,

        [CssClass("fa-squarespace")]
        Squarespace,

        [CssClass("fa-squirrel")]
        Squirrel,

        [CssClass("fa-stack-exchange")]
        StackExchange,

        [CssClass("fa-stack-overflow")]
        StackOverflow,

        [CssClass("fa-stackpath")]
        Stackpath,

        [CssClass("fa-staff")]
        Staff,

        [CssClass("fa-stamp")]
        Stamp,

        [CssClass("fa-star")]
        Star,

        [CssClass("fa-star-and-crescent")]
        StarAndCrescent,

        [CssClass("fa-star-christmas")]
        StarChristmas,

        [CssClass("fa-star-exclamation")]
        StarExclamation,

        [CssClass("fa-star-half")]
        StarHalf,

        [CssClass("fa-star-half-alt")]
        StarHalfAlt,

        [CssClass("fa-star-of-david")]
        StarOfDavid,

        [CssClass("fa-star-of-life")]
        StarOfLife,

        [CssClass("fa-star-shooting")]
        StarShooting,

        [CssClass("fa-starfighter")]
        Starfighter,

        [CssClass("fa-starfighter-alt")]
        StarfighterAlt,

        [CssClass("fa-stars")]
        Stars,

        [CssClass("fa-starship")]
        Starship,

        [CssClass("fa-starship-freighter")]
        StarshipFreighter,

        [CssClass("fa-staylinked")]
        Staylinked,

        [CssClass("fa-steak")]
        Steak,

        [CssClass("fa-steam")]
        Steam,

        [CssClass("fa-steam-square")]
        SteamSquare,

        [CssClass("fa-steam-symbol")]
        SteamSymbol,

        [CssClass("fa-steering-wheel")]
        SteeringWheel,

        [CssClass("fa-step-backward")]
        StepBackward,

        [CssClass("fa-step-forward")]
        StepForward,

        [CssClass("fa-stethoscope")]
        Stethoscope,

        [CssClass("fa-sticker-mule")]
        StickerMule,

        [CssClass("fa-sticky-note")]
        StickyNote,

        [CssClass("fa-stocking")]
        Stocking,

        [CssClass("fa-stomach")]
        Stomach,

        [CssClass("fa-stop")]
        Stop,

        [CssClass("fa-stop-circle")]
        StopCircle,

        [CssClass("fa-stopwatch")]
        Stopwatch,

        [CssClass("fa-stopwatch-20")]
        Stopwatch20,

        [CssClass("fa-store")]
        Store,

        [CssClass("fa-store-alt")]
        StoreAlt,

        [CssClass("fa-store-alt-slash")]
        StoreAltSlash,

        [CssClass("fa-store-slash")]
        StoreSlash,

        [CssClass("fa-strava")]
        Strava,

        [CssClass("fa-stream")]
        Stream,

        [CssClass("fa-street-view")]
        StreetView,

        [CssClass("fa-stretcher")]
        Stretcher,

        [CssClass("fa-strikethrough")]
        Strikethrough,

        [CssClass("fa-stripe")]
        Stripe,

        [CssClass("fa-stripe-s")]
        StripeS,

        [CssClass("fa-stroopwafel")]
        Stroopwafel,

        [CssClass("fa-studiovinari")]
        Studiovinari,

        [CssClass("fa-stumbleupon")]
        Stumbleupon,

        [CssClass("fa-stumbleupon-circle")]
        StumbleuponCircle,

        [CssClass("fa-subscript")]
        Subscript,

        [CssClass("fa-subway")]
        Subway,

        [CssClass("fa-suitcase")]
        Suitcase,

        [CssClass("fa-suitcase-rolling")]
        SuitcaseRolling,

        [CssClass("fa-sun")]
        Sun,

        [CssClass("fa-sun-cloud")]
        SunCloud,

        [CssClass("fa-sun-dust")]
        SunDust,

        [CssClass("fa-sun-haze")]
        SunHaze,

        [CssClass("fa-sunglasses")]
        Sunglasses,

        [CssClass("fa-sunrise")]
        Sunrise,

        [CssClass("fa-sunset")]
        Sunset,

        [CssClass("fa-superpowers")]
        Superpowers,

        [CssClass("fa-superscript")]
        Superscript,

        [CssClass("fa-supple")]
        Supple,

        [CssClass("fa-surprise")]
        Surprise,

        [CssClass("fa-suse")]
        Suse,

        [CssClass("fa-swatchbook")]
        Swatchbook,

        [CssClass("fa-swift")]
        Swift,

        [CssClass("fa-swimmer")]
        Swimmer,

        [CssClass("fa-swimming-pool")]
        SwimmingPool,

        [CssClass("fa-sword")]
        Sword,

        [CssClass("fa-sword-laser")]
        SwordLaser,

        [CssClass("fa-sword-laser-alt")]
        SwordLaserAlt,

        [CssClass("fa-swords")]
        Swords,

        [CssClass("fa-swords-laser")]
        SwordsLaser,

        [CssClass("fa-symfony")]
        Symfony,

        [CssClass("fa-synagogue")]
        Synagogue,

        [CssClass("fa-sync")]
        Sync,

        [CssClass("fa-sync-alt")]
        SyncAlt,

        [CssClass("fa-syringe")]
        Syringe,

        [CssClass("fa-table")]
        Table,

        [CssClass("fa-table-tennis")]
        TableTennis,

        [CssClass("fa-tablet")]
        Tablet,

        [CssClass("fa-tablet-alt")]
        TabletAlt,

        [CssClass("fa-tablet-android")]
        TabletAndroid,

        [CssClass("fa-tablet-android-alt")]
        TabletAndroidAlt,

        [CssClass("fa-tablet-rugged")]
        TabletRugged,

        [CssClass("fa-tablets")]
        Tablets,

        [CssClass("fa-tachometer")]
        Tachometer,

        [CssClass("fa-tachometer-alt")]
        TachometerAlt,

        [CssClass("fa-tachometer-alt-average")]
        TachometerAltAverage,

        [CssClass("fa-tachometer-alt-fast")]
        TachometerAltFast,

        [CssClass("fa-tachometer-alt-fastest")]
        TachometerAltFastest,

        [CssClass("fa-tachometer-alt-slow")]
        TachometerAltSlow,

        [CssClass("fa-tachometer-alt-slowest")]
        TachometerAltSlowest,

        [CssClass("fa-tachometer-average")]
        TachometerAverage,

        [CssClass("fa-tachometer-fast")]
        TachometerFast,

        [CssClass("fa-tachometer-fastest")]
        TachometerFastest,

        [CssClass("fa-tachometer-slow")]
        TachometerSlow,

        [CssClass("fa-tachometer-slowest")]
        TachometerSlowest,

        [CssClass("fa-taco")]
        Taco,

        [CssClass("fa-tag")]
        Tag,

        [CssClass("fa-tags")]
        Tags,

        [CssClass("fa-tally")]
        Tally,

        [CssClass("fa-tanakh")]
        Tanakh,

        [CssClass("fa-tape")]
        Tape,

        [CssClass("fa-tasks")]
        Tasks,

        [CssClass("fa-tasks-alt")]
        TasksAlt,

        [CssClass("fa-taxi")]
        Taxi,

        [CssClass("fa-teamspeak")]
        Teamspeak,

        [CssClass("fa-teeth")]
        Teeth,

        [CssClass("fa-teeth-open")]
        TeethOpen,

        [CssClass("fa-telegram")]
        Telegram,

        [CssClass("fa-telegram-plane")]
        TelegramPlane,

        [CssClass("fa-telescope")]
        Telescope,

        [CssClass("fa-temperature-down")]
        TemperatureDown,

        [CssClass("fa-temperature-frigid")]
        TemperatureFrigid,

        [CssClass("fa-temperature-high")]
        TemperatureHigh,

        [CssClass("fa-temperature-hot")]
        TemperatureHot,

        [CssClass("fa-temperature-low")]
        TemperatureLow,

        [CssClass("fa-temperature-up")]
        TemperatureUp,

        [CssClass("fa-tencent-weibo")]
        TencentWeibo,

        [CssClass("fa-tenge")]
        Tenge,

        [CssClass("fa-tennis-ball")]
        TennisBall,

        [CssClass("fa-terminal")]
        Terminal,

        [CssClass("fa-text")]
        Text,

        [CssClass("fa-text-height")]
        TextHeight,

        [CssClass("fa-text-size")]
        TextSize,

        [CssClass("fa-text-width")]
        TextWidth,

        [CssClass("fa-th")]
        Th,

        [CssClass("fa-th-large")]
        ThLarge,

        [CssClass("fa-th-list")]
        ThList,

        [CssClass("fa-the-red-yeti")]
        TheRedYeti,

        [CssClass("fa-theater-masks")]
        TheaterMasks,

        [CssClass("fa-themeco")]
        Themeco,

        [CssClass("fa-themeisle")]
        Themeisle,

        [CssClass("fa-thermometer")]
        Thermometer,

        [CssClass("fa-thermometer-empty")]
        ThermometerEmpty,

        [CssClass("fa-thermometer-full")]
        ThermometerFull,

        [CssClass("fa-thermometer-half")]
        ThermometerHalf,

        [CssClass("fa-thermometer-quarter")]
        ThermometerQuarter,

        [CssClass("fa-thermometer-three-quarters")]
        ThermometerThreeQuarters,

        [CssClass("fa-theta")]
        Theta,

        [CssClass("fa-think-peaks")]
        ThinkPeaks,

        [CssClass("fa-thumbs-down")]
        ThumbsDown,

        [CssClass("fa-thumbs-up")]
        ThumbsUp,

        [CssClass("fa-thumbtack")]
        Thumbtack,

        [CssClass("fa-thunderstorm")]
        Thunderstorm,

        [CssClass("fa-thunderstorm-moon")]
        ThunderstormMoon,

        [CssClass("fa-thunderstorm-sun")]
        ThunderstormSun,

        [CssClass("fa-ticket")]
        Ticket,

        [CssClass("fa-ticket-alt")]
        TicketAlt,

        [CssClass("fa-tiktok")]
        Tiktok,

        [CssClass("fa-tilde")]
        Tilde,

        [CssClass("fa-times")]
        Times,

        [CssClass("fa-times-circle")]
        TimesCircle,

        [CssClass("fa-times-hexagon")]
        TimesHexagon,

        [CssClass("fa-times-octagon")]
        TimesOctagon,

        [CssClass("fa-times-square")]
        TimesSquare,

        [CssClass("fa-tint")]
        Tint,

        [CssClass("fa-tint-slash")]
        TintSlash,

        [CssClass("fa-tire")]
        Tire,

        [CssClass("fa-tire-flat")]
        TireFlat,

        [CssClass("fa-tire-pressure-warning")]
        TirePressureWarning,

        [CssClass("fa-tire-rugged")]
        TireRugged,

        [CssClass("fa-tired")]
        Tired,

        [CssClass("fa-toggle-off")]
        ToggleOff,

        [CssClass("fa-toggle-on")]
        ToggleOn,

        [CssClass("fa-toilet")]
        Toilet,

        [CssClass("fa-toilet-paper")]
        ToiletPaper,

        [CssClass("fa-toilet-paper-alt")]
        ToiletPaperAlt,

        [CssClass("fa-toilet-paper-slash")]
        ToiletPaperSlash,

        [CssClass("fa-tombstone")]
        Tombstone,

        [CssClass("fa-tombstone-alt")]
        TombstoneAlt,

        [CssClass("fa-toolbox")]
        Toolbox,

        [CssClass("fa-tools")]
        Tools,

        [CssClass("fa-tooth")]
        Tooth,

        [CssClass("fa-toothbrush")]
        Toothbrush,

        [CssClass("fa-torah")]
        Torah,

        [CssClass("fa-torii-gate")]
        ToriiGate,

        [CssClass("fa-tornado")]
        Tornado,

        [CssClass("fa-tractor")]
        Tractor,

        [CssClass("fa-trade-federation")]
        TradeFederation,

        [CssClass("fa-trademark")]
        Trademark,

        [CssClass("fa-traffic-cone")]
        TrafficCone,

        [CssClass("fa-traffic-light")]
        TrafficLight,

        [CssClass("fa-traffic-light-go")]
        TrafficLightGo,

        [CssClass("fa-traffic-light-slow")]
        TrafficLightSlow,

        [CssClass("fa-traffic-light-stop")]
        TrafficLightStop,

        [CssClass("fa-trailer")]
        Trailer,

        [CssClass("fa-train")]
        Train,

        [CssClass("fa-tram")]
        Tram,

        [CssClass("fa-transgender")]
        Transgender,

        [CssClass("fa-transgender-alt")]
        TransgenderAlt,

        [CssClass("fa-transporter")]
        Transporter,

        [CssClass("fa-transporter-1")]
        Transporter1,

        [CssClass("fa-transporter-2")]
        Transporter2,

        [CssClass("fa-transporter-3")]
        Transporter3,

        [CssClass("fa-transporter-empty")]
        TransporterEmpty,

        [CssClass("fa-trash")]
        Trash,

        [CssClass("fa-trash-alt")]
        TrashAlt,

        [CssClass("fa-trash-restore")]
        TrashRestore,

        [CssClass("fa-trash-restore-alt")]
        TrashRestoreAlt,

        [CssClass("fa-trash-undo")]
        TrashUndo,

        [CssClass("fa-trash-undo-alt")]
        TrashUndoAlt,

        [CssClass("fa-treasure-chest")]
        TreasureChest,

        [CssClass("fa-tree")]
        Tree,

        [CssClass("fa-tree-alt")]
        TreeAlt,

        [CssClass("fa-tree-christmas")]
        TreeChristmas,

        [CssClass("fa-tree-decorated")]
        TreeDecorated,

        [CssClass("fa-tree-large")]
        TreeLarge,

        [CssClass("fa-tree-palm")]
        TreePalm,

        [CssClass("fa-trees")]
        Trees,

        [CssClass("fa-trello")]
        Trello,

        [CssClass("fa-triangle")]
        Triangle,

        [CssClass("fa-triangle-music")]
        TriangleMusic,

        [CssClass("fa-tripadvisor")]
        Tripadvisor,

        [CssClass("fa-trophy")]
        Trophy,

        [CssClass("fa-trophy-alt")]
        TrophyAlt,

        [CssClass("fa-truck")]
        Truck,

        [CssClass("fa-truck-container")]
        TruckContainer,

        [CssClass("fa-truck-couch")]
        TruckCouch,

        [CssClass("fa-truck-loading")]
        TruckLoading,

        [CssClass("fa-truck-monster")]
        TruckMonster,

        [CssClass("fa-truck-moving")]
        TruckMoving,

        [CssClass("fa-truck-pickup")]
        TruckPickup,

        [CssClass("fa-truck-plow")]
        TruckPlow,

        [CssClass("fa-truck-ramp")]
        TruckRamp,

        [CssClass("fa-trumpet")]
        Trumpet,

        [CssClass("fa-tshirt")]
        Tshirt,

        [CssClass("fa-tty")]
        Tty,

        [CssClass("fa-tumblr")]
        Tumblr,

        [CssClass("fa-tumblr-square")]
        TumblrSquare,

        [CssClass("fa-turkey")]
        Turkey,

        [CssClass("fa-turntable")]
        Turntable,

        [CssClass("fa-turtle")]
        Turtle,

        [CssClass("fa-tv")]
        Tv,

        [CssClass("fa-tv-alt")]
        TvAlt,

        [CssClass("fa-tv-music")]
        TvMusic,

        [CssClass("fa-tv-retro")]
        TvRetro,

        [CssClass("fa-twitch")]
        Twitch,

        [CssClass("fa-twitter")]
        Twitter,

        [CssClass("fa-twitter-square")]
        TwitterSquare,

        [CssClass("fa-typewriter")]
        Typewriter,

        [CssClass("fa-typo3")]
        Typo3,

        [CssClass("fa-uber")]
        Uber,

        [CssClass("fa-ubuntu")]
        Ubuntu,

        [CssClass("fa-ufo")]
        Ufo,

        [CssClass("fa-ufo-beam")]
        UfoBeam,

        [CssClass("fa-uikit")]
        Uikit,

        [CssClass("fa-umbraco")]
        Umbraco,

        [CssClass("fa-umbrella")]
        Umbrella,

        [CssClass("fa-umbrella-beach")]
        UmbrellaBeach,

        [CssClass("fa-uncharted")]
        Uncharted,

        [CssClass("fa-underline")]
        Underline,

        [CssClass("fa-undo")]
        Undo,

        [CssClass("fa-undo-alt")]
        UndoAlt,

        [CssClass("fa-unicorn")]
        Unicorn,

        [CssClass("fa-union")]
        Union,

        [CssClass("fa-uniregistry")]
        Uniregistry,

        [CssClass("fa-unity")]
        Unity,

        [CssClass("fa-universal-access")]
        UniversalAccess,

        [CssClass("fa-university")]
        University,

        [CssClass("fa-unlink")]
        Unlink,

        [CssClass("fa-unlock")]
        Unlock,

        [CssClass("fa-unlock-alt")]
        UnlockAlt,

        [CssClass("fa-unsplash")]
        Unsplash,

        [CssClass("fa-untappd")]
        Untappd,

        [CssClass("fa-upload")]
        Upload,

        [CssClass("fa-ups")]
        Ups,

        [CssClass("fa-usb")]
        Usb,

        [CssClass("fa-usb-drive")]
        UsbDrive,

        [CssClass("fa-usd-circle")]
        UsdCircle,

        [CssClass("fa-usd-square")]
        UsdSquare,

        [CssClass("fa-user")]
        User,

        [CssClass("fa-user-alien")]
        UserAlien,

        [CssClass("fa-user-alt")]
        UserAlt,

        [CssClass("fa-user-alt-slash")]
        UserAltSlash,

        [CssClass("fa-user-astronaut")]
        UserAstronaut,

        [CssClass("fa-user-chart")]
        UserChart,

        [CssClass("fa-user-check")]
        UserCheck,

        [CssClass("fa-user-circle")]
        UserCircle,

        [CssClass("fa-user-clock")]
        UserClock,

        [CssClass("fa-user-cog")]
        UserCog,

        [CssClass("fa-user-cowboy")]
        UserCowboy,

        [CssClass("fa-user-crown")]
        UserCrown,

        [CssClass("fa-user-edit")]
        UserEdit,

        [CssClass("fa-user-friends")]
        UserFriends,

        [CssClass("fa-user-graduate")]
        UserGraduate,

        [CssClass("fa-user-hard-hat")]
        UserHardHat,

        [CssClass("fa-user-headset")]
        UserHeadset,

        [CssClass("fa-user-injured")]
        UserInjured,

        [CssClass("fa-user-lock")]
        UserLock,

        [CssClass("fa-user-md")]
        UserMd,

        [CssClass("fa-user-md-chat")]
        UserMdChat,

        [CssClass("fa-user-minus")]
        UserMinus,

        [CssClass("fa-user-music")]
        UserMusic,

        [CssClass("fa-user-ninja")]
        UserNinja,

        [CssClass("fa-user-nurse")]
        UserNurse,

        [CssClass("fa-user-plus")]
        UserPlus,

        [CssClass("fa-user-robot")]
        UserRobot,

        [CssClass("fa-user-secret")]
        UserSecret,

        [CssClass("fa-user-shield")]
        UserShield,

        [CssClass("fa-user-slash")]
        UserSlash,

        [CssClass("fa-user-tag")]
        UserTag,

        [CssClass("fa-user-tie")]
        UserTie,

        [CssClass("fa-user-times")]
        UserTimes,

        [CssClass("fa-user-unlock")]
        UserUnlock,

        [CssClass("fa-user-visor")]
        UserVisor,

        [CssClass("fa-users")]
        Users,

        [CssClass("fa-users-class")]
        UsersClass,

        [CssClass("fa-users-cog")]
        UsersCog,

        [CssClass("fa-users-crown")]
        UsersCrown,

        [CssClass("fa-users-medical")]
        UsersMedical,

        [CssClass("fa-users-slash")]
        UsersSlash,

        [CssClass("fa-usps")]
        Usps,

        [CssClass("fa-ussunnah")]
        Ussunnah,

        [CssClass("fa-utensil-fork")]
        UtensilFork,

        [CssClass("fa-utensil-knife")]
        UtensilKnife,

        [CssClass("fa-utensil-spoon")]
        UtensilSpoon,

        [CssClass("fa-utensils")]
        Utensils,

        [CssClass("fa-utensils-alt")]
        UtensilsAlt,

        [CssClass("fa-vaadin")]
        Vaadin,

        [CssClass("fa-vacuum")]
        Vacuum,

        [CssClass("fa-vacuum-robot")]
        VacuumRobot,

        [CssClass("fa-value-absolute")]
        ValueAbsolute,

        [CssClass("fa-vector-square")]
        VectorSquare,

        [CssClass("fa-venus")]
        Venus,

        [CssClass("fa-venus-double")]
        VenusDouble,

        [CssClass("fa-venus-mars")]
        VenusMars,

        [CssClass("fa-vest")]
        Vest,

        [CssClass("fa-vest-patches")]
        VestPatches,

        [CssClass("fa-vhs")]
        Vhs,

        [CssClass("fa-viacoin")]
        Viacoin,

        [CssClass("fa-viadeo")]
        Viadeo,

        [CssClass("fa-viadeo-square")]
        ViadeoSquare,

        [CssClass("fa-vial")]
        Vial,

        [CssClass("fa-vials")]
        Vials,

        [CssClass("fa-viber")]
        Viber,

        [CssClass("fa-video")]
        Video,

        [CssClass("fa-video-plus")]
        VideoPlus,

        [CssClass("fa-video-slash")]
        VideoSlash,

        [CssClass("fa-vihara")]
        Vihara,

        [CssClass("fa-vimeo")]
        Vimeo,

        [CssClass("fa-vimeo-square")]
        VimeoSquare,

        [CssClass("fa-vimeo-v")]
        VimeoV,

        [CssClass("fa-vine")]
        Vine,

        [CssClass("fa-violin")]
        Violin,

        [CssClass("fa-virus")]
        Virus,

        [CssClass("fa-virus-slash")]
        VirusSlash,

        [CssClass("fa-viruses")]
        Viruses,

        [CssClass("fa-vk")]
        Vk,

        [CssClass("fa-vnv")]
        Vnv,

        [CssClass("fa-voicemail")]
        Voicemail,

        [CssClass("fa-volcano")]
        Volcano,

        [CssClass("fa-volleyball-ball")]
        VolleyballBall,

        [CssClass("fa-volume")]
        Volume,

        [CssClass("fa-volume-down")]
        VolumeDown,

        [CssClass("fa-volume-mute")]
        VolumeMute,

        [CssClass("fa-volume-off")]
        VolumeOff,

        [CssClass("fa-volume-slash")]
        VolumeSlash,

        [CssClass("fa-volume-up")]
        VolumeUp,

        [CssClass("fa-vote-nay")]
        VoteNay,

        [CssClass("fa-vote-yea")]
        VoteYea,

        [CssClass("fa-vr-cardboard")]
        VrCardboard,

        [CssClass("fa-vuejs")]
        Vuejs,

        [CssClass("fa-wagon-covered")]
        WagonCovered,

        [CssClass("fa-walker")]
        Walker,

        [CssClass("fa-walkie-talkie")]
        WalkieTalkie,

        [CssClass("fa-walking")]
        Walking,

        [CssClass("fa-wallet")]
        Wallet,

        [CssClass("fa-wand")]
        Wand,

        [CssClass("fa-wand-magic")]
        WandMagic,

        [CssClass("fa-warehouse")]
        Warehouse,

        [CssClass("fa-warehouse-alt")]
        WarehouseAlt,

        [CssClass("fa-washer")]
        Washer,

        [CssClass("fa-watch")]
        Watch,

        [CssClass("fa-watch-calculator")]
        WatchCalculator,

        [CssClass("fa-watch-fitness")]
        WatchFitness,

        [CssClass("fa-watchman-monitoring")]
        WatchmanMonitoring,

        [CssClass("fa-water")]
        Water,

        [CssClass("fa-water-lower")]
        WaterLower,

        [CssClass("fa-water-rise")]
        WaterRise,

        [CssClass("fa-wave-sine")]
        WaveSine,

        [CssClass("fa-wave-square")]
        WaveSquare,

        [CssClass("fa-wave-triangle")]
        WaveTriangle,

        [CssClass("fa-waveform")]
        Waveform,

        [CssClass("fa-waveform-path")]
        WaveformPath,

        [CssClass("fa-waze")]
        Waze,

        [CssClass("fa-webcam")]
        Webcam,

        [CssClass("fa-webcam-slash")]
        WebcamSlash,

        [CssClass("fa-weebly")]
        Weebly,

        [CssClass("fa-weibo")]
        Weibo,

        [CssClass("fa-weight")]
        Weight,

        [CssClass("fa-weight-hanging")]
        WeightHanging,

        [CssClass("fa-weixin")]
        Weixin,

        [CssClass("fa-whale")]
        Whale,

        [CssClass("fa-whatsapp")]
        Whatsapp,

        [CssClass("fa-whatsapp-square")]
        WhatsappSquare,

        [CssClass("fa-wheat")]
        Wheat,

        [CssClass("fa-wheelchair")]
        Wheelchair,

        [CssClass("fa-whistle")]
        Whistle,

        [CssClass("fa-whmcs")]
        Whmcs,

        [CssClass("fa-wifi")]
        Wifi,

        [CssClass("fa-wifi-1")]
        Wifi1,

        [CssClass("fa-wifi-2")]
        Wifi2,

        [CssClass("fa-wifi-slash")]
        WifiSlash,

        [CssClass("fa-wikipedia-w")]
        WikipediaW,

        [CssClass("fa-wind")]
        Wind,

        [CssClass("fa-wind-turbine")]
        WindTurbine,

        [CssClass("fa-wind-warning")]
        WindWarning,

        [CssClass("fa-window")]
        Window,

        [CssClass("fa-window-alt")]
        WindowAlt,

        [CssClass("fa-window-close")]
        WindowClose,

        [CssClass("fa-window-frame")]
        WindowFrame,

        [CssClass("fa-window-frame-open")]
        WindowFrameOpen,

        [CssClass("fa-window-maximize")]
        WindowMaximize,

        [CssClass("fa-window-minimize")]
        WindowMinimize,

        [CssClass("fa-window-restore")]
        WindowRestore,

        [CssClass("fa-windows")]
        Windows,

        [CssClass("fa-windsock")]
        Windsock,

        [CssClass("fa-wine-bottle")]
        WineBottle,

        [CssClass("fa-wine-glass")]
        WineGlass,

        [CssClass("fa-wine-glass-alt")]
        WineGlassAlt,

        [CssClass("fa-wix")]
        Wix,

        [CssClass("fa-wizards-of-the-coast")]
        WizardsOfTheCoast,

        [CssClass("fa-wodu")]
        Wodu,

        [CssClass("fa-wolf-pack-battalion")]
        WolfPackBattalion,

        [CssClass("fa-won-sign")]
        WonSign,

        [CssClass("fa-wordpress")]
        Wordpress,

        [CssClass("fa-wordpress-simple")]
        WordpressSimple,

        [CssClass("fa-wpbeginner")]
        Wpbeginner,

        [CssClass("fa-wpexplorer")]
        Wpexplorer,

        [CssClass("fa-wpforms")]
        Wpforms,

        [CssClass("fa-wpressr")]
        Wpressr,

        [CssClass("fa-wreath")]
        Wreath,

        [CssClass("fa-wrench")]
        Wrench,

        [CssClass("fa-x-ray")]
        XRay,

        [CssClass("fa-xbox")]
        Xbox,

        [CssClass("fa-xing")]
        Xing,

        [CssClass("fa-xing-square")]
        XingSquare,

        [CssClass("fa-y-combinator")]
        YCombinator,

        [CssClass("fa-yahoo")]
        Yahoo,

        [CssClass("fa-yammer")]
        Yammer,

        [CssClass("fa-yandex")]
        Yandex,

        [CssClass("fa-yandex-international")]
        YandexInternational,

        [CssClass("fa-yarn")]
        Yarn,

        [CssClass("fa-yelp")]
        Yelp,

        [CssClass("fa-yen-sign")]
        YenSign,

        [CssClass("fa-yin-yang")]
        YinYang,

        [CssClass("fa-yoast")]
        Yoast,

        [CssClass("fa-youtube")]
        Youtube,

        [CssClass("fa-youtube-square")]
        YoutubeSquare,

        [CssClass("fa-zhihu")]
        Zhihu
    }
}
