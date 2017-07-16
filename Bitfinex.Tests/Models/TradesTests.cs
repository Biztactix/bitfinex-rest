﻿using System.Collections.Generic;
using Bitfinex.JsonConverters;
using Bitfinex.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace Bitfinex.Tests.Models
{
    [TestClass]
    public class TradesTests
    {
        [TestMethod]
        public void TradesDeserializeTest1()
        {
            //GET: https://api.bitfinex.com/v2/trades/fUSD/hist
            string json = "[ [ 8819908, 1499993669662, -42.48113687, 0.00026573, 2 ], [ 8819907, 1499993669637, -93.08533495, 0.00026571, 2 ], [ 8819906, 1499993669606, -80.23924126, 0.0002657, 2 ], [ 8819905, 1499993669580, -80.23924126, 0.0002657, 2 ], [ 8819904, 1499993669555, -90.44483913, 0.0002657, 2 ], [ 8819903, 1499993669508, -53.77420134, 0.0002657, 2 ], [ 8819902, 1499993669472, -53.77420134, 0.0002657, 2 ], [ 8819901, 1499993669408, -53.77420134, 0.0002657, 2 ], [ 8819900, 1499993669374, -2.6136619, 0.0002657, 2 ], [ 8819895, 1499993667107, -51.16053944, 0.0002657, 2 ], [ 8819894, 1499993667086, -53.77420134, 0.0002657, 2 ], [ 8819893, 1499993667057, -53.77420134, 0.0002657, 2 ], [ 8819892, 1499993667031, -2474.20793604, 0.0002657, 2 ], [ 8819891, 1499993667006, -53.77420134, 0.00026563, 2 ], [ 8819890, 1499993666980, -53.77420134, 0.00026563, 2 ], [ 8819889, 1499993666960, -53.77420134, 0.00026563, 2 ], [ 8819888, 1499993666933, -53.77420134, 0.00026563, 2 ], [ 8819887, 1499993666907, -53.77420134, 0.00026563, 2 ], [ 8819886, 1499993666887, -53.77420134, 0.00026563, 2 ], [ 8819885, 1499993666863, -53.77420134, 0.00026563, 2 ], [ 8819884, 1499993666843, -646.52363859, 0.00026563, 2 ], [ 8819883, 1499993666818, -4948.41587208, 0.00026563, 2 ], [ 8819882, 1499993666767, -87.03953651, 0.00026563, 2 ], [ 8819881, 1499993666727, -80.23924126, 0.00026562, 2 ], [ 8819880, 1499993666691, -80.23924126, 0.00026562, 2 ], [ 8819879, 1499993666658, -90.44483913, 0.00026562, 2 ], [ 8819878, 1499993666630, -53.77420134, 0.0002656, 2 ], [ 8819877, 1499993666605, -53.77420134, 0.0002656, 2 ], [ 8819876, 1499993666573, -80.23924126, 0.00026494, 2 ], [ 8819875, 1499993666536, -80.23924126, 0.00026494, 2 ], [ 8819874, 1499993666505, -4083.5268, 0.00026494, 2 ], [ 8819873, 1499993666478, -50, 0.0002649, 2 ], [ 8819872, 1499993666447, -1768.6234, 0.0002648, 2 ], [ 8819871, 1499993666416, -98.37, 0.0002648, 3 ], [ 8819870, 1499993666371, -169.69, 0.0002648, 3 ], [ 8819869, 1499993666311, -80.23924126, 0.0002647, 2 ], [ 8819868, 1499993666288, -90.44483913, 0.0002647, 2 ], [ 8819867, 1499993666256, -2474.20793604, 0.0002647, 2 ], [ 8819866, 1499993666222, -5081.18275562, 0.00026468, 2 ], [ 8819865, 1499993666200, -11078.18090284, 0.00026468, 2 ], [ 8819864, 1499993666152, -900.84877392, 0.00026368, 2 ], [ 8819839, 1499993661552, -24.08470096, 0.00026368, 2 ], [ 8819838, 1499993661481, -73.62422513, 0.00026368, 2 ], [ 8819832, 1499993655549, -20561.66978856, 0.00026468, 2 ], [ 8819831, 1499993654708, -14.1942157, 0.00026468, 2 ], [ 8819829, 1499993654659, -2.45249997, 0.00022719, 2 ], [ 8819827, 1499993653789, -47.54750003, 0.00022719, 2 ], [ 8819826, 1499993653730, -0.215336, 0.00026468, 2 ], [ 8819825, 1499993653665, -6163.58260527, 0.00026468, 2 ], [ 8819824, 1499993653601, -1962.84, 0.00026467, 2 ], [ 8819823, 1499993653567, -1326.7468018, 0.00026465, 2 ], [ 8819822, 1499993653459, -56.90229132, 0.00026387, 2 ], [ 8819821, 1499993653411, -237.783, 0.00026387, 2 ], [ 8819820, 1499993653372, -111.95655804, 0.00026368, 2 ], [ 8819819, 1499993653337, -80.23924126, 0.0002617, 2 ], [ 8819818, 1499993653277, -596.14230575, 0.0002617, 2 ], [ 8819817, 1499993653250, -80.23924126, 0.00023966, 2 ], [ 8819815, 1499993653196, -80.23924126, 0.00023966, 2 ], [ 8819814, 1499993653159, -80.23924126, 0.00023966, 2 ], [ 8819813, 1499993653100, -80.23924126, 0.00023966, 2 ], [ 8819812, 1499993653074, -80.23924126, 0.00023966, 2 ], [ 8819811, 1499993652976, -80.23924126, 0.00023966, 2 ], [ 8819810, 1499993652937, -451, 0.000236, 2 ], [ 8819809, 1499993652914, -56.90229132, 0.0002296, 2 ], [ 8819808, 1499993652888, -56.24275274, 0.0002296, 2 ], [ 8819807, 1499993652857, -56.24275274, 0.0002296, 2 ], [ 8819806, 1499993652812, -90.44483913, 0.00022749, 2 ], [ 8819805, 1499993652734, -1882.80746053, 0.00022749, 2 ], [ 8819804, 1499993652652, -85.14923868, 0.0002274, 2 ], [ 8819803, 1499993652628, -1408.82154882, 0.0002273, 2 ], [ 8819802, 1499993652569, -1408.82154882, 0.0002273, 2 ], [ 8819801, 1499993652510, -599.4112884, 0.0002273, 2 ], [ 8819799, 1499993652458, -599.4112884, 0.0002273, 2 ], [ 8819798, 1499993652356, -90.44483913, 0.0002273, 2 ], [ 8819797, 1499993652294, -4287.06443826, 0.0002273, 2 ], [ 8819796, 1499993651901, -779.58632982, 0.0002273, 2 ], [ 8819775, 1499993648738, -86.4999999, 0.0002273, 2 ], [ 8819773, 1499993647636, -215.50975942, 0.0002273, 2 ], [ 8819772, 1499993646194, -29.67599058, 0.0002273, 2 ], [ 8819765, 1499993643036, -54.1290761, 0.0002273, 2 ], [ 8819759, 1499993639396, -1.66913336, 0.0002273, 2 ], [ 8819756, 1499993638220, -179.39355176, 0.0002273, 2 ], [ 8819755, 1499993638152, -50, 0.0002273, 2 ], [ 8819754, 1499993638118, -50, 0.0002273, 2 ], [ 8819753, 1499993638081, -68.79399651, 0.0002273, 2 ], [ 8819752, 1499993635466, -190.02840302, 0.0002273, 2 ], [ 8819751, 1499993633585, -0.19886031, 0.0002273, 2 ], [ 8819750, 1499993632156, -44.3313754, 0.0002273, 2 ], [ 8819748, 1499993628217, -15.38736476, 0.0002273, 2 ], [ 8819747, 1499993628140, -65.45692284, 0.0002271, 2 ], [ 8819746, 1499993628040, -57.25490182, 0.0002271, 2 ], [ 8819745, 1499993625767, -25.019, 0.0002271, 2 ], [ 8819744, 1499993624420, -4.75883443, 0.0002271, 2 ], [ 8819743, 1499993622485, -753.56998339, 0.0002271, 2 ], [ 8819742, 1499993621593, -568.21882918, 0.0002271, 2 ], [ 8819741, 1499993621541, -599.4112884, 0.0002271, 2 ], [ 8819740, 1499993621484, -110.97509029, 0.0002271, 2 ], [ 8819739, 1499993621416, -50, 0.00022492, 2 ], [ 8819738, 1499993621357, -50, 0.00022481, 2 ], [ 8819737, 1499993621272, -602.16479213, 0.00022465, 2 ], [ 8819736, 1499993621192, -5.3639181, 0.00022465, 2 ], [ 8819732, 1499993584813, -50, 0.00022465, 2 ], [ 8819731, 1499993353283, -19, 0.0002659, 2 ], [ 8819729, 1499993352687, -967.61447872, 0.0002659, 2 ], [ 8819727, 1499993352105, -1167.98962257, 0.0002659, 2 ], [ 8819725, 1499993351249, -16023.36348933, 0.0002659, 2 ], [ 8819724, 1499993351230, -2098.64941318, 0.0002659, 2 ], [ 8819719, 1499993347667, -71.1836148, 0.0002659, 2 ], [ 8819718, 1499993347647, -135.7293452, 0.0002658, 2 ], [ 8819717, 1499993347624, -509.22367437, 0.0002658, 2 ], [ 8819712, 1499993346579, -52.37534993, 0.0002658, 2 ], [ 8819708, 1499993343496, -0.65331699, 0.0002658, 2 ], [ 8819707, 1499993343468, -2530.78440774, 0.0002658, 2 ], [ 8819706, 1499993343446, -1263.84, 0.0002658, 2 ], [ 8819705, 1499993343424, -120.35886189, 0.000265, 2 ], [ 8819704, 1499993343403, -120.35886189, 0.000265, 2 ], [ 8819703, 1499993343380, -120.35886189, 0.000265, 2 ], [ 8819702, 1499993343358, -147.42764988, 0.000265, 2 ], [ 8819701, 1499993342997, -1.30474549, 0.000265, 2 ], [ 8819697, 1499993341704, -7127.22537711, 0.000265, 2 ]]";

            var trades = JsonConvert.DeserializeObject<List<ITrade>>(json, new TradesResultConverter());

            Assert.AreEqual(120, trades.Count);

            var trade = trades[0];

            Assert.AreEqual(8819908, trade.ID);
            Assert.AreEqual(1499993669662, trade.MTS);
            Assert.AreEqual(-42.48113687, trade.Amount);
            Assert.AreEqual(0.00026573, trade.Rate);
            Assert.AreEqual(2, trade.Period.Milliseconds);
        }

        [TestMethod]
        public void TradesDeserializeTest2()
        {
            //GET: https://api.bitfinex.com/v2/trades/tBTCUSD/hist
            string json = "[ [ 43394880,1499994152000,0.17690843,2328.5 ], [ 43394873,1499994150000,0.18519263,2327.4 ], [ 43394867,1499994150000,1.14752541,2327.4 ], [ 43394855,1499994149000,0.05865396,2327.4 ], [ 43394846,1499994147000,0.02318898,2327.4 ], [ 43394836,1499994146000,0.23783591,2327.4 ], [ 43394834,1499994145000,0.02318898,2327.4 ], [ 43394826,1499994144000,0.32221829,2327.4 ], [ 43394819,1499994142000,0.37469225,2327.4 ], [ 43394816,1499994141000,0.03474767,2327.4 ], [ 43394814,1499994141000,0.02318898,2327.4 ], [ 43394810,1499994140000,0.02318898,2327.4 ], [ 43394807,1499994138000,0.02318898,2327.4 ], [ 43394805,1499994138000,0.02318898,2327.4 ], [ 43394774,1499994131000,0.40368858,2328.4 ], [ 43394772,1499994130000,-0.02203571,2325.6 ], [ 43394765,1499994127000,-0.97025747,2325 ], [ 43394764,1499994127000,-0.02974253,2325.1 ], [ 43394761,1499994125000,0.04901382,2328.826517 ], [ 43394749,1499994123000,0.03475254,2328.9 ], [ 43394748,1499994123000,0.38448517,2328.8 ], [ 43394746,1499994123000,0.02317404,2328.8 ], [ 43394736,1499994122000,0.3517295,2328.6 ], [ 43394731,1499994122000,0.0114784,2328.4 ], [ 43394726,1499994121000,0.06794646,2328.6 ], [ 43394725,1499994121000,0.07849665,2328.6 ], [ 43394724,1499994121000,0.08878369,2328.6 ], [ 43394722,1499994121000,0.02318898,2328.6 ], [ 43394720,1499994121000,0.17095246,2328.6 ], [ 43394721,1499994121000,0.41161218,2328.6 ], [ 43394719,1499994121000,1.32474152,2328.48422708 ], [ 43394715,1499994121000,0.79070252,2328.4 ], [ 43394714,1499994121000,0.40200175,2326 ], [ 43394711,1499994120000,-1,2325.8 ], [ 43394712,1499994120000,-1,2324.6 ], [ 43394709,1499994120000,0.02317703,2326 ], [ 43394708,1499994120000,-0.46084585,2326.1 ], [ 43394706,1499994120000,-0.02463224,2327.5 ], [ 43394707,1499994120000,-0.01326427,2327.4 ], [ 43394705,1499994120000,-0.02317802,2327.5 ], [ 43394703,1499994120000,-0.02971186,2327.5 ], [ 43394704,1499994120000,-0.02318898,2327.5 ], [ 43394702,1499994120000,0.06794895,2328.48422708 ], [ 43394698,1499994120000,-0.07849665,2328.5 ], [ 43394696,1499994120000,-0.58516317,2328.5 ], [ 43394694,1499994120000,-2.97594971,2328.5 ], [ 43394693,1499994120000,0.01023869,2328.6 ], [ 43394692,1499994120000,0.04725539,2328.6 ], [ 43394690,1499994120000,1.48713934,2328.6 ], [ 43394689,1499994119000,0.26265666,2328.6 ], [ 43394679,1499994118000,0.58516838,2328.5 ], [ 43394678,1499994118000,2.78,2328.4 ], [ 43394671,1499994117000,0.69470349,2328.5 ], [ 43394659,1499994116000,2.18,2328 ], [ 43394658,1499994116000,2,2328 ], [ 43394657,1499994116000,0.43688155,2327.4 ], [ 43394652,1499994115000,0.25954174,2327.4 ], [ 43394624,1499994114000,0.46085107,2327.3 ], [ 43394619,1499994114000,-1.092,2324.5 ], [ 43394594,1499994111000,0.29256214,2327.4 ], [ 43394593,1499994111000,0.7063306,2327.4 ], [ 43394589,1499994106000,0.27069119,2327.4 ], [ 43394582,1499994106000,1.27858048,2326.3 ], [ 43394585,1499994106000,0.62399278,2327.4 ], [ 43394584,1499994106000,0.09184,2327 ], [ 43394583,1499994106000,0.06101,2327 ], [ 43394576,1499994104000,0.094141,2326.3 ], [ 43394573,1499994104000,0.15572938,2326.3 ], [ 43394570,1499994103000,0.2442483,2326.3 ], [ 43394569,1499994103000,0.02318468,2326.3 ], [ 43394567,1499994102000,0.04332964,2326.3 ], [ 43394565,1499994101000,0.16078652,2326.3 ], [ 43394564,1499994101000,0.09263292,2325.2 ], [ 43394554,1499994100000,0.01450442,2325.2 ], [ 43394552,1499994100000,0.24479336,2325.2 ], [ 43394551,1499994100000,0.03473686,2325.2 ], [ 43394548,1499994100000,1.47532161,2325.2 ], [ 43394545,1499994099000,0.13801083,2325.2 ], [ 43394532,1499994092000,0.0347511,2326.3 ], [ 43394478,1499994077000,-0.07911615,2322.6 ], [ 43394466,1499994072000,0.03472337,2326.7 ], [ 43394436,1499994061000,-0.00255144,2324 ], [ 43394435,1499994061000,-0.05653288,2324.7 ], [ 43394434,1499994061000,-0.02974637,2324.8 ], [ 43394428,1499994059000,-0.19081844,2324.6 ], [ 43394426,1499994058000,-0.03,2324.6 ], [ 43394427,1499994058000,-0.22563985,2324.6 ], [ 43394421,1499994056000,0.02978511,2326.8 ], [ 43394402,1499994053000,0.02975149,2324.1 ], [ 43394401,1499994052000,0.02975149,2324.1 ], [ 43394400,1499994052000,-0.02975405,2324.2 ], [ 43394399,1499994052000,-0.05889999,2324.3 ], [ 43394390,1499994049000,0.24059868,2327 ], [ 43394389,1499994049000,2.15397713,2326.7 ], [ 43394373,1499994042000,0.2649,2326.9 ], [ 43394371,1499994041000,0.29952499,2326.8 ], [ 43394370,1499994041000,0.231,2326.7 ], [ 43394369,1499994041000,0.22570366,2326.5 ], [ 43394358,1499994038000,0.16658644,2326.8 ], [ 43394357,1499994038000,0.19205067,2326.3 ], [ 43394356,1499994037000,0.03103501,2326.3 ], [ 43394350,1499994037000,0.09209846,2326.3 ], [ 43394346,1499994036000,0.30647881,2326.3 ], [ 43394338,1499994035000,0.65932398,2326.3 ], [ 43394320,1499994026000,0.20895066,2326.1 ], [ 43394321,1499994026000,0.46331131,2326.5 ], [ 43394316,1499994023000,0.23867355,2326.1 ], [ 43394315,1499994023000,0.9607694,2326.1 ], [ 43394309,1499994022000,0.15718346,2326.1 ], [ 43394295,1499994016000,0.03842293,2326.1 ], [ 43394290,1499994014000,1.0187638,2326.2 ], [ 43394233,1499994008000,0.23819137,2326.4 ], [ 43394231,1499994008000,0.01613,2324.9 ], [ 43394232,1499994008000,0.18408,2324.9 ], [ 43394230,1499994007000,0.07501416,2324.8 ], [ 43394229,1499994007000,0.95048185,2324.7 ], [ 43394212,1499993988000,-0.04514027,2322.5 ], [ 43394210,1499993987000,0.01,2324.7 ], [ 43394206,1499993987000,-0.03370366,2322.4 ], [ 43394200,1499993987000,0.01001815,2324.7 ] ]";

            var trades = JsonConvert.DeserializeObject<List<ITrade>>(json, new TradesResultConverter());

            Assert.AreEqual(120, trades.Count);

            var trade = trades[0];

            Assert.AreEqual(43394880, trade.ID);
            Assert.AreEqual(1499994152000, trade.MTS);
            Assert.AreEqual(0.17690843, trade.Amount);
            Assert.AreEqual(2328.5, trade.Price);
        }

        [TestMethod]
        public void TradesClientTest()
        {
            var client = new BitfinexRestClient();
            var trades = client.GetTrades("tBTCUSD", 50, 0, 0, SortDirection.NewestToOldest);

            Assert.AreEqual(50, trades.Count);
        }
    }
}