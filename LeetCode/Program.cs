﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 2. 两数相加

            //Console.WriteLine("342 + 465 = " + ResolveListNode(AddTwoNumbers(MakeListNode("342"), MakeListNode("465"))));
            //Console.WriteLine("5 + 5 = " + ResolveListNode(AddTwoNumbers(MakeListNode("5"), MakeListNode("5"))));

            #endregion

            #region 4. 寻找两个有序数组的中位数

            //Console.WriteLine(FindMedianSortedArrays(new[] { 1, 3 }, new[] { 2 }) == 2.0 ? "Yes" : "No");
            //Console.WriteLine(FindMedianSortedArrays(new[] { 1, 2 }, new[] { 3, 4 }) == 2.5 ? "Yes" : "No");
            //Console.WriteLine(FindMedianSortedArrays(new[] { 3 }, new[] { -2, -1 }) == -1.0 ? "Yes" : "No");
            //Console.WriteLine(FindMedianSortedArrays(new[] { 181, 209, 255, 313, 332, 334, 421, 455, 500, 516, 527, 543, 619, 635, 667, 702, 706, 725, 833, 877, 888, 900, 909, 923, 959, 975, 992, 1084, 1088, 1224, 1270, 1377, 1410, 1433, 1443, 1511, 1565, 1607, 1608, 1624, 1627, 1636, 1651, 1678, 1916, 1971, 2047, 2104, 2116, 2119, 2139, 2145, 2157, 2163, 2204, 2233, 2239, 2263, 2271, 2276, 2276, 2277, 2288, 2311, 2358, 2367, 2419, 2422, 2440, 2522, 2610, 2644, 2712, 2718, 2842, 2928, 2933, 2943, 2954, 2986, 3005, 3039, 3078, 3154, 3160, 3162, 3211, 3231, 3254, 3368, 3400, 3405, 3408, 3411, 3423, 3458, 3460, 3461, 3485, 3496, 3505, 3548, 3552, 3594, 3611, 3641, 3676, 3699, 3709, 3809, 3812, 3821, 3838, 3893, 3931, 3959, 3968, 4005, 4036, 4043, 4044, 4063, 4083, 4102, 4130, 4264, 4291, 4317, 4319, 4329, 4367, 4380, 4396, 4426, 4463, 4485, 4527, 4532, 4539, 4551, 4562, 4600, 4664, 4664, 4669, 4680, 4734, 4743, 4745, 4746, 4840, 4874, 4890, 4938, 4950, 4955, 4979, 4994, 5008, 5012, 5091, 5097, 5131, 5137, 5152, 5159, 5216, 5227, 5229, 5240, 5244, 5314, 5359, 5414, 5496, 5575, 5599, 5643, 5704, 5711, 5743, 5785, 5786, 5809, 5831, 5849, 5859, 5896, 6125, 6138, 6145, 6196, 6199, 6200, 6222, 6222, 6229, 6283, 6299, 6306, 6344, 6363, 6388, 6395, 6420, 6435, 6439, 6449, 6477, 6512, 6515, 6534, 6535, 6542, 6573, 6590, 6592, 6599, 6613, 6662, 6740, 6748, 6769, 6820, 6900, 6906, 6911, 7041, 7060, 7095, 7161, 7174, 7201, 7214, 7230, 7301, 7327, 7347, 7370, 7390, 7395, 7425, 7460, 7477, 7501, 7507, 7534, 7562, 7570, 7576, 7668, 7670, 7700, 7702, 7736, 7765, 7774, 7800, 7822, 7865, 7895, 7991, 8002, 8020, 8058, 8076, 8088, 8133, 8155, 8205, 8211, 8234, 8287, 8309, 8353, 8443, 8468, 8494, 8503, 8542, 8542, 8542, 8623, 8626, 8662, 8718, 8745, 8762, 8848, 8904, 8954, 8998, 9117, 9147, 9159, 9208, 9292, 9343, 9344, 9379, 9477, 9502, 9570, 9619, 9656, 9713, 9737, 9838, 9936, 9975, 9984, 9998, 10006, 10016, 10031, 10074, 10092, 10102, 10139, 10195, 10258, 10263, 10283, 10305, 10337, 10355, 10358, 10360, 10360, 10399, 10420, 10484, 10569, 10588, 10590, 10611, 10616, 10680, 10681, 10685, 10688, 10720, 10726, 10727, 10732, 10766, 10877, 10897, 10918, 10977, 11004, 11077, 11088, 11169, 11241, 11272, 11298, 11304, 11322, 11341, 11359, 11360, 11442, 11443, 11467, 11481, 11486, 11521, 11544, 11595, 11620, 11632, 11652, 11676, 11684, 11724, 11743, 11889, 11897, 11909, 11926, 11928, 11984, 11987, 12015, 12072, 12114, 12203, 12310, 12354, 12363, 12372, 12379, 12406, 12446, 12447, 12456, 12464, 12534, 12540, 12576, 12656, 12717, 12788, 12804, 12808, 12852, 12864, 12874, 12886, 12973, 12983, 13005, 13029, 13038, 13045, 13050, 13055, 13071, 13081, 13095, 13132, 13174, 13182, 13200, 13344, 13379, 13380, 13406, 13414, 13454, 13474, 13506, 13510, 13518, 13555, 13588, 13607, 13663, 13673, 13685, 13789, 13825, 13842, 13870, 13904, 13917, 13935, 13954, 14005, 14012, 14032, 14081, 14107, 14133, 14149, 14157, 14160, 14180, 14203, 14207, 14281, 14294, 14307, 14369, 14415, 14425, 14477, 14566, 14631, 14653, 14661, 14721, 14726, 14741, 14742, 14762, 14776, 14795, 14915, 14944, 14970, 14988, 15101, 15128, 15147, 15147, 15150, 15168, 15193, 15210, 15269, 15292, 15310, 15324, 15340, 15346, 15348, 15370, 15483, 15512, 15515, 15541, 15544, 15589, 15627, 15628, 15795, 15826, 15826, 15835, 15844, 15844, 15860, 15904, 15968, 15975, 15978, 15991, 16056, 16106, 16129, 16141, 16155, 16171, 16190, 16204, 16239, 16269, 16283, 16315, 16332, 16383, 16421, 16446, 16496, 16526, 16527, 16534, 16591, 16592, 16625, 16637, 16648, 16654, 16654, 16693, 16758, 16781, 16787, 16840, 16861, 16927, 16933, 16935, 17109, 17160, 17210, 17212, 17213, 17289, 17289, 17327, 17389, 17431, 17517, 17670, 17686, 17707, 17714, 17717, 17775, 17830, 17839, 17863, 17904, 17933, 17966, 18006, 18027, 18091, 18103, 18196, 18234, 18256, 18262, 18359, 18378, 18385, 18395, 18400, 18419, 18466, 18481, 18492, 18514, 18530, 18592, 18603, 18669, 18742, 18765, 18777, 18779, 18806, 18845, 18862, 18923, 18955, 18964, 18967, 19006, 19042, 19072, 19139, 19158, 19225, 19389, 19394, 19564, 19592, 19594, 19733, 19800, 19822, 19856, 19882, 20028, 20086, 20149, 20244, 20244, 20254, 20263, 20272, 20292, 20336, 20352, 20355, 20376, 20400, 20419, 20493, 20495, 20504, 20555, 20616, 20626, 20755, 20763, 20839, 20862, 20951, 20956, 20956, 20985, 20995, 21010, 21065, 21128, 21148, 21279, 21285, 21314, 21338, 21340, 21373, 21432, 21510, 21512, 21519, 21571, 21578, 21648, 21679, 21729, 21749, 21809, 21823, 21839, 21852, 21996, 22006, 22033, 22056, 22065, 22087, 22171, 22271, 22317, 22342, 22355, 22434, 22443, 22461, 22472, 22478, 22484, 22499, 22528, 22530, 22590, 22590, 22594, 22627, 22705, 22721, 22737, 22738, 22764, 22778, 22826, 22877, 22889, 22901, 22953, 23014, 23074, 23150, 23200, 23301, 23386, 23443, 23483, 23493, 23518, 23598, 23683, 23732, 23733, 23738, 23784, 23813, 23838, 23846, 23847, 23860, 23862, 23870, 23886, 23987, 23989, 23989, 23993, 24089, 24097, 24120, 24122, 24135, 24196, 24258, 24271, 24290, 24299, 24333, 24352, 24394, 24432, 24432, 24442, 24443, 24481, 24484, 24503, 24512, 24524, 24527, 24537, 24565, 24603, 24619, 24676, 24721, 24798, 24800, 24802, 24830, 24880, 24968, 24975, 24977, 24984, 24988, 24988, 25017, 25042, 25082, 25122, 25125, 25215, 25255, 25262, 25341, 25366, 25436, 25442, 25478, 25586, 25605, 25611, 25618, 25677, 25715, 25766, 25789, 25794, 25852, 25916, 26030, 26161, 26204, 26227, 26249, 26297, 26350, 26358, 26362, 26383, 26488, 26491, 26521, 26537, 26544, 26551, 26556, 26573, 26594, 26600, 26609, 26682, 26686, 26688, 26695, 26750, 26790, 26833, 26861, 26876, 26886, 26887, 26914, 26940, 26941, 26972, 27019, 27093, 27145, 27200, 27217, 27226, 27255, 27334, 27386, 27428, 27466, 27562, 27596, 27627, 27693, 27701, 27717, 27743, 27753, 27768, 27817, 27884, 27900, 27972, 27993, 28003, 28015, 28064, 28065, 28100, 28140, 28183, 28244, 28258, 28342, 28369, 28508, 28525, 28594, 28604, 28636, 28721, 28736, 28749, 28755, 28772, 28782, 28886, 28909, 28940, 28962, 28971, 29072, 29072, 29116, 29152, 29200, 29249, 29341, 29348, 29411, 29411, 29455, 29456, 29480, 29486, 29494, 29511, 29590, 29591, 29615, 29664, 29670, 29742, 29769, 29857, 29899, 29953, 30065, 30072, 30075, 30092, 30097, 30114, 30117, 30117, 30157, 30183, 30193, 30209, 30304, 30304, 30320, 30345, 30434, 30539, 30560, 30724, 30742, 30757, 30799, 30809, 30856, 30859, 30896, 30918, 30937, 30976, 31026, 31041, 31045, 31132, 31227, 31278, 31331, 31353, 31372, 31382, 31435, 31512, 31537, 31545, 31546, 31554, 31619, 31658, 31795, 31855, 31857, 31901, 31920, 31921, 31928, 31978, 32014, 32035, 32047, 32095, 32142, 32142, 32158, 32162, 32176, 32197, 32269, 32328, 32438, 32466, 32486, 32523, 32609, 32614, 32617, 32622, 32680, 32710 }
            //                                       , new[] { 20, 45, 65, 91, 195, 199, 216, 234, 235, 258, 260, 268, 343, 365, 502, 515, 532, 560, 561, 583, 605, 605, 608, 764, 776, 861, 886, 941, 956, 980, 1002, 1006, 1014, 1042, 1102, 1127, 1135, 1157, 1166, 1167, 1185, 1189, 1190, 1210, 1241, 1255, 1284, 1292, 1319, 1349, 1400, 1413, 1421, 1427, 1441, 1448, 1482, 1525, 1570, 1571, 1574, 1611, 1634, 1636, 1641, 1734, 1828, 2004, 2005, 2009, 2029, 2041, 2044, 2053, 2202, 2227, 2255, 2271, 2386, 2393, 2413, 2423, 2455, 2459, 2481, 2498, 2561, 2569, 2579, 2619, 2647, 2676, 2738, 2811, 2851, 2868, 2889, 3013, 3016, 3083, 3108, 3141, 3167, 3222, 3223, 3330, 3339, 3402, 3421, 3452, 3486, 3495, 3546, 3592, 3618, 3643, 3686, 3720, 3785, 3786, 3790, 3791, 3832, 3897, 3910, 3926, 3977, 3995, 4009, 4013, 4040, 4053, 4095, 4127, 4204, 4218, 4241, 4341, 4354, 4367, 4409, 4431, 4496, 4497, 4508, 4540, 4545, 4552, 4557, 4627, 4652, 4657, 4714, 4727, 4731, 4736, 4824, 4872, 4891, 4951, 4971, 5197, 5203, 5253, 5284, 5307, 5400, 5447, 5448, 5451, 5518, 5527, 5535, 5590, 5636, 5644, 5719, 5725, 5737, 5752, 5769, 5786, 5805, 5831, 5836, 5878, 5921, 5968, 6020, 6028, 6078, 6105, 6111, 6113, 6126, 6136, 6155, 6182, 6198, 6200, 6233, 6246, 6258, 6275, 6276, 6281, 6301, 6301, 6421, 6455, 6479, 6488, 6493, 6554, 6570, 6587, 6623, 6699, 6712, 6727, 6777, 6795, 6809, 6906, 6961, 6995, 7164, 7174, 7230, 7273, 7274, 7281, 7312, 7339, 7408, 7410, 7437, 7450, 7501, 7519, 7524, 7540, 7543, 7565, 7616, 7643, 7711, 7717, 7722, 7726, 7780, 7834, 7845, 7880, 7987, 8036, 8085, 8099, 8142, 8147, 8177, 8210, 8215, 8262, 8268, 8291, 8318, 8346, 8347, 8387, 8426, 8458, 8530, 8574, 8588, 8623, 8642, 8665, 8850, 9016, 9049, 9074, 9076, 9085, 9102, 9103, 9103, 9112, 9171, 9230, 9291, 9317, 9361, 9435, 9463, 9467, 9514, 9535, 9535, 9573, 9578, 9587, 9595, 9599, 9605, 9609, 9683, 9699, 9706, 9740, 9796, 9806, 9832, 9848, 9855, 9919, 9932, 9946, 9981, 10008, 10134, 10262, 10274, 10320, 10447, 10449, 10479, 10505, 10506, 10513, 10561, 10571, 10591, 10759, 10853, 10878, 10880, 10900, 10926, 10932, 10959, 10972, 10973, 10976, 11052, 11075, 11112, 11113, 11146, 11183, 11211, 11232, 11251, 11269, 11296, 11297, 11300, 11314, 11357, 11371, 11378, 11384, 11410, 11461, 11461, 11540, 11550, 11613, 11644, 11653, 11715, 11784, 11788, 11796, 11885, 11912, 11913, 11915, 11954, 12010, 12012, 12168, 12173, 12325, 12346, 12352, 12411, 12416, 12439, 12443, 12449, 12460, 12467, 12478, 12502, 12596, 12629, 12682, 12692, 12708, 12745, 12770, 12796, 12808, 12903, 13016, 13090, 13102, 13145, 13156, 13220, 13232, 13255, 13298, 13302, 13306, 13323, 13368, 13494, 13648, 13655, 13675, 13682, 13697, 13722, 13783, 13825, 13869, 13909, 13943, 13985, 14015, 14018, 14068, 14148, 14167, 14249, 14252, 14255, 14330, 14344, 14418, 14543, 14567, 14575, 14576, 14646, 14687, 14689, 14725, 14725, 14789, 14806, 14828, 14886, 14895, 14949, 14957, 14969, 14970, 14989, 14996, 15000, 15003, 15032, 15033, 15064, 15066, 15069, 15078, 15090, 15154, 15169, 15199, 15224, 15240, 15255, 15326, 15403, 15497, 15504, 15526, 15552, 15632, 15638, 15638, 15653, 15669, 15748, 15843, 15866, 15872, 15875, 15889, 15915, 15984, 16026, 16034, 16071, 16075, 16167, 16218, 16221, 16226, 16231, 16273, 16287, 16287, 16292, 16305, 16332, 16387, 16424, 16456, 16503, 16512, 16526, 16579, 16604, 16634, 16642, 16654, 16666, 16668, 16700, 16709, 16716, 16732, 16769, 16771, 16773, 16778, 16854, 16855, 16862, 16864, 16882, 16913, 16919, 16928, 16935, 16949, 16977, 16978, 17016, 17053, 17073, 17137, 17163, 17166, 17211, 17227, 17235, 17329, 17333, 17359, 17430, 17472, 17512, 17558, 17609, 17700, 17705, 17724, 17729, 17739, 17773, 17854, 17867, 17871, 17880, 17968, 17983, 18050, 18052, 18062, 18068, 18114, 18119, 18176, 18266, 18305, 18340, 18424, 18460, 18521, 18579, 18606, 18617, 18672, 18683, 18685, 18705, 18710, 18720, 18739, 18765, 18778, 18800, 18813, 18852, 18907, 18934, 18981, 19001, 19011, 19017, 19027, 19057, 19126, 19129, 19169, 19179, 19201, 19204, 19235, 19240, 19240, 19244, 19334, 19353, 19375, 19383, 19411, 19414, 19433, 19433, 19441, 19450, 19456, 19541, 19544, 19557, 19570, 19632, 19675, 19695, 19716, 19756, 19774, 19780, 19795, 19811, 19833, 19886, 19921, 19930, 19980, 20065, 20075, 20093, 20109, 20113, 20141, 20156, 20163, 20171, 20231, 20273, 20295, 20304, 20338, 20386, 20386, 20433, 20471, 20511, 20540, 20591, 20621, 20709, 20713, 20730, 20770, 20802, 20803, 20840, 20846, 20874, 20911, 20930, 20949, 20978, 21003, 21013, 21022, 21041, 21055, 21104, 21177, 21182, 21215, 21235, 21330, 21360, 21372, 21380, 21417, 21436, 21484, 21485, 21569, 21638, 21725, 21800, 21804, 21832, 21856, 21961, 21987, 22055, 22067, 22092, 22150, 22304, 22408, 22420, 22446, 22477, 22619, 22628, 22635, 22643, 22648, 22675, 22678, 22680, 22722, 22777, 22830, 22905, 22910, 22955, 22982, 23016, 23026, 23078, 23185, 23223, 23228, 23235, 23293, 23307, 23318, 23376, 23421, 23429, 23442, 23509, 23538, 23545, 23556, 23629, 23713, 23730, 23734, 23744, 23782, 23797, 23822, 23865, 23896, 23902, 23915, 23973, 24049, 24049, 24111, 24133, 24145, 24166, 24175, 24197, 24373, 24390, 24415, 24416, 24430, 24443, 24501, 24542, 24561, 24597, 24613, 24638, 24696, 24713, 24761, 24833, 24838, 24844, 24845, 24866, 24995, 25012, 25023, 25029, 25091, 25138, 25156, 25194, 25220, 25221, 25295, 25301, 25335, 25342, 25359, 25369, 25429, 25477, 25488, 25511, 25536, 25594, 25638, 25658, 25704, 25719, 25773, 25861, 25921, 25972, 26000, 26013, 26050, 26343, 26351, 26354, 26399, 26415, 26416, 26448, 26473, 26563, 26637, 26640, 26643, 26662, 26721, 26763, 26824, 26891, 26921, 26950, 27021, 27068, 27100, 27107, 27174, 27185, 27264, 27281, 27304, 27348, 27404, 27428, 27478, 27529, 27531, 27541, 27574, 27607, 27663, 27724, 27727, 27736, 27737, 27747, 27758, 27788, 27829, 27837, 27888, 27913, 27914, 27941, 27988, 28000, 28042, 28063, 28107, 28156, 28176, 28178, 28266, 28319, 28366, 28380, 28491, 28516, 28567, 28602, 28609, 28622, 28665, 28699, 28748, 28808, 28812, 28884, 28931, 28947, 28953, 29046, 29063, 29114, 29173, 29193, 29196, 29201, 29255, 29310, 29311, 29416, 29470, 29510, 29532, 29597, 29743, 29795, 29798, 29823, 29915, 29955, 29999, 30009, 30025, 30062, 30071, 30077, 30078, 30112, 30116, 30126, 30127, 30150, 30258, 30272, 30302, 30317, 30396, 30442, 30555, 30564, 30567, 30571, 30616, 30665, 30667, 30875, 30934, 30951, 31080, 31143, 31149, 31175, 31198, 31208, 31226, 31245, 31248, 31315, 31318, 31323, 31351, 31352, 31354, 31372, 31460, 31471, 31484, 31549, 31559, 31568, 31643, 31648, 31663, 31665, 31698, 31782, 31785, 31813, 31851, 31857, 31863, 31937, 32095, 32099, 32105, 32115, 32117, 32218, 32226, 32294, 32384, 32490, 32528, 32588, 32698 }
            //                                       ) == 15839.0 ? "Yes" : "No");
            //Console.WriteLine(FindMedianSortedArrays(new[] { 1, 2 }, new[] { -1, 3 }) == 1.5 ? "Yes" : "No");
            //Console.WriteLine(FindMedianSortedArrays(new[] { 2 }, new[] { 1, 3, 4 }) == 2.5 ? "Yes" : "No");
            //Console.WriteLine(FindMedianSortedArrays(new[] { 1, 2 }, new[] { 3, 4, 5, 6 }) == 3.5 ? "Yes" : "No");
            //Console.WriteLine(FindMedianSortedArrays(new[] { 1, 2, 5 }, new[] { 3, 4, 6 }) == 3.5 ? "Yes" : "No");
            //Console.WriteLine(FindMedianSortedArrays(new[] { 1, 2, 6, 7 }, new[] { 3, 4, 5, 8 }) == 4.5 ? "Yes" : "No");

            #endregion

            #region 32. 最长有效括号

            //Console.WriteLine(LongestValidParentheses("(()") == 2 ? "Yes" : "No");
            //Console.WriteLine(LongestValidParentheses(")()())") == 4 ? "Yes" : "No");
            //Console.WriteLine(LongestValidParentheses(")(") == 0 ? "Yes" : "No");
            //Console.WriteLine(LongestValidParentheses("()(())") == 6 ? "Yes" : "No");
            //Console.WriteLine(LongestValidParentheses(")()(((())))(") == 10 ? "Yes" : "No");
            //Console.WriteLine(LongestValidParentheses(")(((((()())()()))()(()))(") == 22 ? "Yes" : "No");
            //Console.WriteLine(LongestValidParentheses("()(()") == 2 ? "Yes" : "No");
            //Console.WriteLine(LongestValidParentheses("") == 0 ? "Yes" : "No");

            #endregion

            #region 121. 买卖股票的最佳时机

            //Console.WriteLine(MaxProfit(new int[] { 7, 1, 5, 3, 6, 4 }) == 5 ? "Yes" : "No");
            //Console.WriteLine(MaxProfit(new int[] { 7, 6, 4, 3, 1 }) == 0 ? "Yes" : "No");

            #endregion

            #region 122. 买卖股票的最佳时机 II

            //Console.WriteLine(MaxProfitII(new int[] { 7, 1, 5, 3, 6, 4 }) == 7 ? "Yes" : "No");
            //Console.WriteLine(MaxProfitII(new int[] { 1, 2, 3, 4, 5 }) == 4 ? "Yes" : "No");
            //Console.WriteLine(MaxProfitII(new int[] { 7, 6, 4, 3, 1 }) == 0 ? "Yes" : "No");

            #endregion

            #region 123. 买卖股票的最佳时机 III

            //Console.WriteLine(MaxProfitIII(new int[] { 3, 3, 5, 0, 0, 3, 1, 4 }) == 6 ? "Yes" : "No");
            //Console.WriteLine(MaxProfitIII(new int[] { 1, 2, 3, 4, 5 }) == 4 ? "Yes" : "No");
            //Console.WriteLine(MaxProfitIII(new int[] { 7, 6, 4, 3, 1 }) == 0 ? "Yes" : "No");

            #endregion

            #region 188. 买卖股票的最佳时机 IV

            //Console.WriteLine(MaxProfitIV(2, new int[] { 2, 4, 1 }) == 2 ? "Yes" : "No");
            //Console.WriteLine(MaxProfitIV(2, new int[] { 3, 2, 6, 5, 0, 3 }) == 7 ? "Yes" : "No");
            //Console.WriteLine(MaxProfitIV(0, new int[] { 1, 3 }) == 0 ? "Yes" : "No");

            #endregion

            #region 206. 反转链表

            //Console.WriteLine(ResolveListNode(ReverseList(MakeListNode("12345"))) == "54321" ? "Yes" : "No");

            #endregion

            #region 289. 生命游戏

            //GameOfLife(new int[][] { new int[] { 0, 1, 0 }, new int[] { 0, 0, 1 }, new int[] { 1, 1, 1 }, new int[] { 0, 0, 0 } });

            #endregion

            #region 292. Nim 游戏

            //Console.WriteLine(CanWinNim(4) ? "Yes" : "No");

            #endregion

            #region 309. 最佳买卖股票时机含冷冻期

            //Console.WriteLine(MaxProfitFreezing(new int[] { 1, 2, 3, 0, 2 }) == 3 ? "Yes" : "No");

            #endregion

            #region 714. 买卖股票的最佳时机含手续费

            //Console.WriteLine(MaxProfitFee(new int[] { 1, 3, 2, 8, 4, 9 }, 2) == 8 ? "Yes" : "No");

            #endregion

            #region 848. 字母移位

            //Console.WriteLine(ShiftingLetters("abc", new[] { 3, 5, 9 }) == "rpl" ? "Yes" : "No");
            //Console.WriteLine(ShiftingLetters("mkgfzkkuxownxvfvxasy", new[] { 505870226, 437526072, 266740649, 224336793, 532917782, 311122363, 567754492, 595798950, 81520022, 684110326, 137742843, 275267355, 856903962, 148291585, 919054234, 467541837, 622939912, 116899933, 983296461, 536563513 }) == "wqqwlcjnkphhsyvrkdod" ? "Yes" : "No");

            #endregion

            Console.ReadKey();
        }

        #region 2. 两数相加

        public static ListNode MakeListNode(string num)
        {
            ListNode res = null;

            MakeListNode(num, ref res);

            return res;
        }

        public static void MakeListNode(string num, ref ListNode res)
        {
            if (num == "")
            {
                return;
            }

            res = new ListNode(Convert.ToInt32(num.Substring(num.Length - 1)));

            MakeListNode(num.Substring(0, num.Length - 1), ref res.next);
        }

        public static string ResolveListNode(ListNode ln)
        {
            if (ln == null)
            {
                return "";
            }

            return ResolveListNode(ln.next) + ln.val;
        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode res = null;

            Add2(l1, l2, false, ref res);

            return res;
        }

        public static void Add2(ListNode l1, ListNode l2, bool isTen, ref ListNode res)
        {
            if (l1 == null && l2 == null && !isTen)
            {
                return;
            }

            int intl1 = 0;
            int intl2 = 0;
            int intres = 0;
            int intr = 0;

            if (l1 != null)
            {
                intl1 = l1.val;
            }
            else
            {
                l1 = new ListNode(0);
            }
            if (l2 != null)
            {
                intl2 = l2.val;
            }
            else
            {
                l2 = new ListNode(0);
            }

            intres = intl1 + intl2 + (isTen ? 1 : 0);

            if (intres >= 10)
            {
                isTen = true;
                intr = intres - 10;
            }
            else
            {
                isTen = false;
                intr = intres;
            }

            res = new ListNode(intr);

            Add2(l1.next, l2.next, isTen, ref res.next);
        }

        #endregion

        #region 4. 寻找两个有序数组的中位数

        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            if (nums1.Length == 0)
            {
                return FindMedian(nums2);
            }
            if (nums2.Length == 0)
            {
                return FindMedian(nums1);
            }
            if (nums1.Length <= 2 || nums2.Length <= 2)
            {
                List<int> nums = new List<int>();
                int n1 = 0;
                int n2 = 0;
                for (int i = 0; i < (nums1.Length + nums2.Length); i++)
                {
                    if (n1 == nums1.Length)
                    {
                        nums.Add(nums2[n2]);
                        n2++;
                        continue;
                    }
                    if (n2 == nums2.Length)
                    {
                        nums.Add(nums1[n1]);
                        n1++;
                        continue;
                    }

                    if (nums1[n1] > nums2[n2])
                    {
                        nums.Add(nums2[n2]);
                        n2++;
                    }
                    else
                    {
                        nums.Add(nums1[n1]);
                        n1++;
                    }
                }

                return FindMedian(nums.ToArray());
            }

            double med1 = FindMedian(nums1);
            double med2 = FindMedian(nums2);

            if (med1 == med2)
            {
                return med1;
            }

            int del = 0;

            if (nums1.Length > nums2.Length)
            {
                del = (nums2.Length % 2) == 0 ? nums2.Length / 2 - 1 : nums2.Length / 2;
            }
            else
            {
                del = (nums1.Length % 2) == 0 ? nums1.Length / 2 - 1 : nums1.Length / 2;
            }

            if (med1 > med2)
            {
                return FindMedianSortedArrays(nums1.Take(nums1.Length - del).ToArray(), nums2.Skip(del).ToArray());
            }
            else
            {
                return FindMedianSortedArrays(nums1.Skip(del).ToArray(), nums2.Take(nums2.Length - del).ToArray());
            }
        }

        public static double FindMedian(int[] num)
        {
            if (num.Length % 2 == 0)
            {
                return (num[num.Length / 2] + num[num.Length / 2 - 1]) / 2.0;
            }
            else
            {
                return num[(num.Length - 1) / 2];
            }
        }

        #endregion

        #region 32. 最长有效括号

        public static int LongestValidParentheses(string s)
        {
            char[] ac = s.ToCharArray();
            List<int> len = new List<int>();

            int leftQ = 0;
            int lent = 0;
            int lentttt = 0;

            for (int i = 0; i < ac.Length; i++)
            {
                if (ac[i] == '(')
                {
                    leftQ++;
                }
                else if (leftQ == 0)
                {
                    len.Add(lentttt);

                    lentttt = 0;
                }
                else
                {
                    leftQ--;
                    lent++;

                    if (leftQ == 0)
                    {
                        lentttt += lent;
                        lent = 0;
                        len.Add(lentttt);
                    }
                }
            }

            leftQ = 0;
            lent = 0;
            lentttt = 0;

            for (int i = ac.Length - 1; i >= 0; i--)
            {
                if (ac[i] == ')')
                {
                    leftQ++;
                }
                else if (leftQ == 0)
                {
                    len.Add(lentttt);

                    lentttt = 0;
                }
                else
                {
                    leftQ--;
                    lent++;

                    if (leftQ == 0)
                    {
                        lentttt += lent;
                        lent = 0;
                        len.Add(lentttt);
                    }
                }
            }

            len.Add(0);

            return len.Max() * 2;
        }

        #endregion

        #region 121. 买卖股票的最佳时机

        public static int MaxProfit(int[] prices)
        {
            if (prices.Length == 0)
            {
                return 0;
            }

            int min = prices[0];
            int profit = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                if (min < prices[i])
                {
                    if (prices[i] - min > profit)
                    {
                        profit = prices[i] - min;
                    }
                }
                else if (min > prices[i])
                {
                    min = prices[i];
                }
            }

            return profit;
        }

        #endregion

        #region 122. 买卖股票的最佳时机 II

        public static int MaxProfitII(int[] prices)
        {
            if (prices.Length == 0)
            {
                return 0;
            }

            int profit = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i - 1] < prices[i])
                {
                    profit += prices[i] - prices[i - 1];
                }
            }

            return profit;
        }

        #endregion

        #region 123. 买卖股票的最佳时机 III

        public static int MaxProfitIII(int[] prices)
        {
            if (prices.Length <= 1)
            {
                return 0;
            }

            //i 天数   j 次数    0 未持有    1 持有
            int[, ,] p = new int[prices.Length, 3, 2];

            for (int i = 0; i < prices.Length; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    if (i / 2 + 1 < j)
                    {
                        p[i, j, 0] = int.MinValue;
                        p[i, j, 1] = int.MinValue;

                        continue;
                    }
                    if (i == 0)
                    {
                        p[0, j, 0] = int.MinValue;
                        p[0, j, 1] = int.MinValue;
                        p[0, 0, 0] = 0;
                        p[0, 1, 1] = -prices[i];

                        continue;
                    }
                    if (j == 0)
                    {
                        p[i, j, 0] = p[i - 1, j, 0];
                        p[i, j, 1] = int.MinValue;

                        continue;
                    }
                    p[i, j, 0] = Math.Max(p[i - 1, j, 0], p[i - 1, j, 1] + prices[i]);

                    p[i, j, 1] = Math.Max(p[i - 1, j - 1, 0] - prices[i], p[i - 1, j, 1]);
                }
            }

            int res = 0;
            for (int i = 0; i < 3; i++)
            {
                res = Math.Max(res, p[prices.Length - 1, i, 0]);
            }

            return res;
        }

        #endregion

        #region 188. 买卖股票的最佳时机 IV

        public static int MaxProfitIV(int k, int[] prices)
        {
            if (prices.Length <= 1 || k == 0)
            {
                return 0;
            }

            if (k > prices.Length)
            {
                return MaxProfitII(prices);
            }

            //i 天数   j 次数    0 未持有    1 持有
            int[, ,] p = new int[prices.Length, k + 1, 2];

            for (int i = 0; i < prices.Length; i++)
            {
                for (int j = 0; j <= k; j++)
                {
                    if (i / 2 + 1 < j)
                    {
                        p[i, j, 0] = int.MinValue;
                        p[i, j, 1] = int.MinValue;

                        continue;
                    }
                    if (i == 0)
                    {
                        p[0, j, 0] = int.MinValue;
                        p[0, j, 1] = int.MinValue;
                        p[0, 0, 0] = 0;
                        p[0, 1, 1] = -prices[i];

                        continue;
                    }
                    if (j == 0)
                    {
                        p[i, j, 0] = p[i - 1, j, 0];
                        p[i, j, 1] = int.MinValue;

                        continue;
                    }

                    p[i, j, 0] = Math.Max(p[i - 1, j, 0], p[i - 1, j, 1] + prices[i]);

                    p[i, j, 1] = Math.Max(p[i - 1, j - 1, 0] - prices[i], p[i - 1, j, 1]);
                }
            }

            int res = 0;
            for (int i = 0; i <= k; i++)
            {
                res = Math.Max(res, p[prices.Length - 1, i, 0]);
            }

            return res;
        }

        #endregion

        #region 206. 反转链表

        public static void ResolveListNode(ListNode ln, ref List<int> l)
        {
            if (ln == null)
            {
                return;
            }

            l.Add(ln.val);
            ResolveListNode(ln.next, ref l);
        }

        public static ListNode MakeListNodeRe(List<int> num)
        {
            ListNode res = new ListNode(Convert.ToInt32(num[num.Count() - 1]));
            num.RemoveAt(num.Count() - 1);

            MakeListNodeRe(num, ref res.next);

            return res;
        }

        public static void MakeListNodeRe(List<int> num, ref ListNode res)
        {
            if (num.Count == 0)
            {
                return;
            }

            res = new ListNode(Convert.ToInt32(num[num.Count() - 1]));
            num.RemoveAt(num.Count() - 1);

            MakeListNodeRe(num, ref res.next);
        }

        public static ListNode ReverseList(ListNode head)
        {
            if (head == null)
            {
                return null;
            }

            List<int> l = new List<int>();
            ResolveListNode(head, ref l);
            return MakeListNodeRe(l);
        }

        #endregion

        #region 289. 生命游戏

        public static void GameOfLife(int[][] board)
        {
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[0].Length; j++)
                {
                    Postion p = new Postion(i, j, board);
                    board[i][j] = p.setNewState();
                }
            }

            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[0].Length; j++)
                {
                    if (board[i][j] == 2)
                        board[i][j] = 1;
                    else if (board[i][j] == 3)
                        board[i][j] = 0;
                }
            }
        }

        public class Postion
        {
            public Postion(int x, int y, int[][] board)
            {
                this.x = x;
                this.y = y;
                this.gameX = board.Length;
                this.gameY = board[0].Length;
                this.board = board;
            }

            public int x { get; set; }

            public int y { get; set; }

            public int gameX { get; set; }

            public int gameY { get; set; }

            public int[][] board { get; set; }

            //演化   0->0:0  1->1:1  0->1:2  1->0:3
            public int setNewState()
            {
                int count = 0;
                for (int i = -1; i <= 1; i++)
                {
                    for (int j = -1; j <= 1; j++)
                    {
                        if (i == 0 && j == 0)
                            continue;
                        if (this.x + i < 0 || this.x + i >= gameX || this.y + j < 0 || this.y + j >= gameY)
                            continue;
                        if (board[this.x + i][this.y + j] % 2 == 1)
                            count++;
                    }
                }

                int stateOld = board[this.x][this.y];
                if (stateOld == 1)
                {
                    if (count < 2 || count > 3)
                    {
                        return stateOld + 2;
                    }
                }
                else if (stateOld == 0)
                {
                    if (count == 3)
                    {
                        return stateOld + 2;
                    }
                }
                return stateOld;
            }
        }

        #endregion

        #region 292. Nim 游戏

        public static bool CanWinNim(int n)
        {
            return n % 4 == 0 ? false : true;
        }

        #endregion

        #region 309. 最佳买卖股票时机含冷冻期

        public static int MaxProfitFreezing(int[] prices)
        {
            int k = (prices.Length + 1) / 3;

            if (prices.Length <= 1 || k == 0)
            {
                return 0;
            }

            //i 天数   j 次数    0 未持有    1 持有
            int[, ,] p = new int[prices.Length, k + 1, 2];

            for (int i = 0; i < prices.Length; i++)
            {
                for (int j = 0; j <= k; j++)
                {
                    if (i / 3 + 1 < j)
                    {
                        p[i, j, 0] = int.MinValue;
                        p[i, j, 1] = int.MinValue;

                        continue;
                    }
                    if (i < 2)
                    {
                        p[0, j, 0] = int.MinValue;
                        p[0, j, 1] = int.MinValue;
                        p[0, 0, 0] = 0;
                        p[0, 1, 1] = -prices[0];
                        p[1, j, 0] = int.MinValue;
                        p[1, j, 1] = int.MinValue;
                        p[1, 0, 0] = 0;
                        p[1, 1, 1] = Math.Max(p[0, 1, 1], -prices[1]);
                        p[1, 1, 0] = p[0, 1, 1] + prices[i];

                        continue;
                    }
                    if (j == 0)
                    {
                        p[i, j, 0] = p[i - 1, j, 0];
                        p[i, j, 1] = int.MinValue;

                        continue;
                    }

                    p[i, j, 0] = Math.Max(p[i - 1, j, 0], p[i - 1, j, 1] + prices[i]);

                    p[i, j, 1] = Math.Max(p[i - 2, j - 1, 0] - prices[i], p[i - 1, j, 1]);
                }
            }

            int res = 0;
            for (int i = 0; i <= k; i++)
            {
                res = Math.Max(res, p[prices.Length - 1, i, 0]);
            }

            return res;
        }

        #endregion

        #region 714. 买卖股票的最佳时机含手续费

        public static int MaxProfitFee(int[] prices, int fee)
        {
            if (prices.Length == 0)
            {
                return 0;
            }

            int profit = 0;
            int buy = prices[0];
            for (int i = 1; i < prices.Length; i++)
            {
                if (buy + fee < prices[i])
                {
                    profit += prices[i] - buy - fee;
                    buy = prices[i] - fee;
                }
                else if (prices[i] < buy)
                {
                    buy = prices[i];
                }
            }

            return profit;
        }

        #endregion

        #region 848. 字母移位

        public static string ShiftingLetters(string S, int[] shifts)
        {
            char[] ac = S.ToCharArray();

            if (shifts.Length <= ac.Length)
            {
                int sum = 0;
                for (int i = shifts.Length - 1; i >= 0; i--)
                {
                    sum += shifts[i] % 26;
                    ac[i] = MoveS(ac[i], sum);
                }
            }
            else
            {
                int sum = 0;
                for (int i = shifts.Length - 1; i > ac.Length - 1; i--)
                {
                    sum += shifts[i] % 26;
                }

                for (int i = ac.Length - 1; i >= 0; i--)
                {
                    sum += shifts[i] % 26;
                    ac[i] = MoveS(ac[i], sum);
                }
            }

            return new string(ac);
        }

        public static char MoveS(char s, int t)
        {
            int ints = (int)s + t % 26;
            if (ints > 122)
            {
                ints = ints - 26;
            }
            return (char)ints;
        }

        #endregion
    }
}
