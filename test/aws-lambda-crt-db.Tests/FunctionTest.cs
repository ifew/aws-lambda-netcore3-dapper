using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Xunit;
using Amazon.Lambda.Core;
using Amazon.Lambda.TestUtilities;

using aws_lambda_netcore3_dapper;
using Microsoft.EntityFrameworkCore;

namespace aws_lambda_netcore3_dapper.Tests
{
    public class FunctionTest
    {

        // [Fact]
        // public void TestServiceGetListDistrict()
        // {
        //     var _options = new DbContextOptionsBuilder<DistrictContext>().UseInMemoryDatabase("district_service").Options;
        //     var _context = new DistrictContext(_options);

        //     _context.Districts.Add(
        //         new DistrictModel { 
        //                 DistrictId = 1,
        //                 Code = 1,
        //                 TitleEng = "Bangkok",
        //                 TitleTha = "กรุงเทพมหานครฯ",
        //                 ProvinceId = 1
        //             });
        //     _context.Districts.Add(
        //         new DistrictModel { 
        //                 DistrictId = 2,
        //                 Code = 2,
        //                 TitleEng = "Chiang Mai",
        //                 TitleTha = "เชียงใหม่",
        //                 ProvinceId = 2
        //             });
        //     _context.SaveChanges();

        //     List<DistrictModel> expected = new List<DistrictModel> { 
        //             new DistrictModel { 
        //                 DistrictId = 1,
        //                 Code = 1,
        //                 TitleEng = "Bangkok",
        //                 TitleTha = "กรุงเทพมหานครฯ",
        //                 ProvinceId = 1
        //             },
        //             new DistrictModel { 
        //                 DistrictId = 2,
        //                 Code = 2,
        //                 TitleEng = "Chiang Mai",
        //                 TitleTha = "เชียงใหม่",
        //                 ProvinceId = 2
        //             }
        //         };

        //     Services _service = new Services(_context);
        //     List<DistrictModel> result = _service.List_district();

        //     Assert.Equal(expected.Count, result.Count);
        //     Assert.Equal(expected[0].TitleEng, result[0].TitleEng);
        //     Assert.Equal(expected[1].TitleEng, result[1].TitleEng);
        //     Assert.Equal(expected[0].TitleTha, result[0].TitleTha);
        //     Assert.Equal(expected[1].TitleTha, result[1].TitleTha);
        //     Assert.Equal(expected[0].Code, result[0].Code);
        //     Assert.Equal(expected[1].Code, result[1].Code);
        //     Assert.Equal(expected[0].ProvinceId, result[0].ProvinceId);
        //     Assert.Equal(expected[1].ProvinceId, result[1].ProvinceId);
        // }
    }
}
