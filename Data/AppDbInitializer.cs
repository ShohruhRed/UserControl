using UserControl.Models;

namespace UserControl.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

                context.Database.EnsureCreated();

                //Cars
                if (!context.Cars.Any())
                {
                    context.Cars.AddRange(new List<Car>()
                    {
                        new Car()
                        {
                            CarName = "Panamera Turbo S",
                            ProfilePictureUrl = "https://previews.dropbox.com/p/thumb/ABpln39DPlZRiqktbkc99lUAkysSaVjLH5FBEMaZxn3-0OFdEN5mc_Pl-l0CT9qyue7Ea9UPAzvc9AwRqyuuw7QevcA3bxcygyozwFCYi5dVu3BtvqtMrnxAaHizhEg0yVSEQLsLgojttPTfTVc-NnS_zpD4JaR2PmCiEB1RI1q61GhbWx37NRzMDFIp5Ck4AaIrW0IOAoqkY4uemmSaO_9fyIVvCKUWCYZHZ22BDC-wg8v72mYGOO5g9IC0t4l60yGbBcVFcxSJmRq2XMVTu9PNKPyZBb6BX2p83Han5FBrygiuYU4P0ejkYL8CV0L6oCDPEdMtsa7esSU39vqZCCha7JjVWGacwQToJNAh-7nnRQdsoAzPcrbBcg68evVPerE/p.jpeg",
                            StartDate = DateTime.Now.AddDays(-200),
                            Description = "luxary"
                        },
                        new Car()
                        {
                            CarName = "Cayenne GT",
                            ProfilePictureUrl = "https://previews.dropbox.com/p/thumb/ABoABdpaliKXw5YabHsfaQ01ILixs4G--1ZHo2ZvoAH3yZH-Wo9hXToZ8epwMlZK4f2yvHr-sVB_3_py_fmMUNpzRsFoaR31pxf01S4UxXj9-1GAXE_JMPyp_5h9x4w7SojiFHkt5uBYMAUfDCZmrvILu1SiCPy6JsiGbrKaQLmR0HqurxWfwHFY4eTVxdC7EZoi4CjF_X3PqNUNkxBx2fHmAWWqZq6hNAJXVYuL7CQVr-FDDWTXJWDK4Xh2TK4jVBR0VQyLSDaC5NzeI1O0zYllvZHn6CNSkP_glyWK0fOBsg3KQeUTWd4MEGLOHKTk13sFHo3e0pwfwIbCnF251hk5ckv48lsAV6BlAF1An_56uLW3s4fsic8PZ2eUQdWW7a8/p.jpeg",
                            StartDate = DateTime.Now,
                            Description = "crossover"
                        },
                        new Car()
                        {
                            CarName = "911",
                            ProfilePictureUrl = "https://previews.dropbox.com/p/thumb/ABopr0AGjnmeMHm58x22ZckEo9AaCK8ur2wvCL80gVgI8vospLmr-7FdOB72dzSRpaTalbA6dh2U6GUbBINOepjzZ9hZGb6Fb4_O1mkFvkR45HKacrLawbCZG8TvQl6gzLjBFmLkyzyyTAEeLIn6TUHrSU5Z11Idaff5bABLqV8u1VQBWo4kskgUP-aKc-gpdXjaszL60wWBFFF6tAf0NZ8Hwk5mBWnYdUEkJmhV7zyyvMPazEhQGFSa8A8LZZGUytGMnNR_kzG6eSA0oL8UMI-u9qqOGIheDzC1oTLirMPGokNhVIlOTdOZDP548U9OsYMSsx0M7YWTK-LzAwAKUfJ-y0Fzt7_TM48Mkfwx2rEV-Y9rTCc8S_T_cnO4tUQ42M4/p.jpeg",
                            StartDate = DateTime.Now.AddDays(10),
                            Description = "sport"
                        },
                         new Car()
                        {
                            CarName = "RANGE ROVER SPORT",
                            ProfilePictureUrl = "https://previews.dropbox.com/p/thumb/ABpaj5ZGa6_QzIPgFPRE_ZlvHD0UGNNtS8pDQcDrH8cKXOzczf6jC0aa9JxsoEwVHOf-G1IoBnv52GI60aFEkAeZRvdsIrz63FT80_HXpHk_4lksrpPyfIBvOcqC4Wo1HV7ADW3WEL3wBvottpxOtCUIS__88Bbv1TN6FpSafPZB9aihSZRoPKmnE2ApQKd-sdkhOzh4veyx1xebp88uiWePSXOe6O31Gh3gGYmakUVXmr2U-SyHV1pp48QygCXTZugTS_gW_hnQHNMjPx54Mv95bIIyArwAAoMhtAZuAWY7mvcMHuauXDfeRikb8tOAFtqOKPWcQjpX6CmWURLJUg6H_LlSHO1x1bCZtnjDu1WkBPzsxem-I5anaatwAzqVFlM/p.jpeg",
                            StartDate = DateTime.Now.AddDays(-200),
                            Description = "luxary"
                        },
                          new Car()
                        {
                            CarName = "RANGE ROVER VELAR",
                            ProfilePictureUrl = "https://previews.dropbox.com/p/thumb/ABprM6uqze4qB7XWFVgsIsQ2wymWpY7YfB7hCPOk65ZZF9KhvM8pEuNacapXFYGfdrMay0k_wxt3Z48UoWECfPA_b-dAaQp3apGanrph63fU4mhSfcAXj2pGXDbHvJwhyXZcP_pdHgYUocqnuJQocxR25dSQlQiB6OwZsGl3wdvl2jSP24D0QJMAR3Kt7k_ZwgA6zzN2MJgLa2CFUZJVBUD4FKazR8TakZeGnoaZ3qUPai2W_eKek2BljBOqfWughlbn6O6tb-8MAGn-KPQLL7eVMp3EMUrfbOoiOBzMwSEURtxSfU0Yh_YFAH3C0_fPd5D8Is-NqEhpuR6BK-IKvQqmaTjYu5nMiOTEmGuvVS53wIOF7nLgNUEDScmY3EbcUhk/p.jpeg",
                            StartDate = DateTime.Now.AddDays(-200),
                            Description = "luxary"
                        },
                           new Car()
                        {
                            CarName = "RANGE ROVER EVOQUE",
                            ProfilePictureUrl = "https://previews.dropbox.com/p/thumb/ABpSIivci_z3nml73qp6zRG1CxwkuYLQNnhUiHtICmwZikWMl5DXXBg3S7rr-z-aGjQtR2Nb_u8yaAUKSGjgRYj_qWN6P7adC0XyPnPEHtzv_Q8C7b8_t3DggIGPKV6mn6jkb3JHACsiG4p_1ScNp2DpXqVlbhpXgYatMmz9X3rBxkoDFD3tMUDvl1ujfbacKKVs8TN8JIPGWQDaYDzxbYiV3BPJI7b65Wt8j3EqtYSP8w1Ri5NQYg0hotplSz7BGFgVVJJHPYwI_nM--OvqctKkWAJoZM1ROPV2nyjIG1IJnRcd6jABKTrh9JXrLGNZod5ID0cTn73do-uIqhHsYIceJFvIizPnrW6CaYQp_nK0vf5KyTzT3OhFTEFZL05QeK8/p.jpeg",
                            StartDate = DateTime.Now.AddDays(-200),
                            Description = "luxary"
                        },
                            new Car()
                        {
                            CarName = "Phantom",
                            ProfilePictureUrl = "https://previews.dropbox.com/p/thumb/ABqXuBvxVP9U6SPrrumDthsCfMV-vseG7KYsoE2vKGiPv2aCat1BzWJkPTfYeR-9vtalpbeFTZYYBKT5EzP2YKwpUE7KZuJ--5pZbWyY_yYNgqqNrX9zokx9S64bF27pIXOYbJGW21R8t0DqFGXMWHy8FLw2u7k_KHs5w6UQe0SNV2kqEeHfPVPk5yjPo-65HtZI8Eh2SsKLsjej0LHV2oSTV-3UIR_UftJLH_flv92ohLOd_Hx4Oy1mrDSW4LlTTRwOHeWxONhtR971KTB68TwJcXAgXEH6oSUs9gD6PywYBpMKdEgCHIvCGLC_D9EC0WMRJNuUyIC3n_LOQx-pAbb1qsxkpzdfpn2cod72WGLB4b-O2Tcyg5eDs8eEP0gp5P0/p.jpeg",
                            StartDate = DateTime.Now,
                            Description = "luxary"
                        },
                             new Car()
                        {
                            CarName = "Ghost",
                            ProfilePictureUrl = "https://previews.dropbox.com/p/thumb/ABqOrDBNKt_31Y-rTjoFBqG1pRLAUnU5S_HK6N3bMii62YeKBGsfRXnRHwYexuYr_43k1XDyY62nvRGQlcjP0LUH4ODeItI0ZiZ9sQARAQ0_XcsAfY_NzoJNJP7dIaAwtO95R-tw04JCCGtaKoJyhN0z1f9rDJ4t9d1qnvzKpxyIst092iyMwk__FTqzrMQovm8IB2HbDxHBEwRb9Vbev6EitvvN0XWQDsew5zgE0mD2QNGeyB8EwVatQu9yy9i_AfuPLmsxG6Ms4SYyep-XFtf1h56ZLf6hiKijKRyBNmcXH93gCsBdoxp80Pb1eMFRds2IHvGg_4Qxh6WIWs_ukuiEf4o0tEyRnqtrl8UnA8APru3vwUhrBWtlClIWCl2WgPA/p.jpeg",
                            StartDate = DateTime.Now,
                            Description = "luxary"
                        },
                              new Car()
                        {
                            CarName = "Spectre",
                            ProfilePictureUrl = "https://previews.dropbox.com/p/thumb/ABpwhqId8QDatDI49nfjKCKQxsdiwekCC8cetIfBYMCJ6ctQzmUF36_t8eij_-vAydNy68NwEQoW--BGdBeDDzvxil7BrIqzEdwVAVdA14l7RtxvJt6decapNb7jqyLxRQ5mFzlql7B_baVJsV-Ziw0xqHhSoZZtdDTtJa9HHZ4ArPUSibYH5Ftb6qFWH2sphbNALCX2L7eVNPq9SFbG87dVurTyXk0-mBRIGUDvRaDvRjYBxPmMtTFhI3Ep4-7xVaEk83jZVY76KR5qjJj5gBKVXWQoqz6X1gdH8Bx61RUTfPeKLdrSnBw3Bk9PjpgvCidktX6xe4ZhIAsHRoH4nS6kLPUoXWe9ivgcnTWN9lJZY3JCFgzvfWYDdRoo0MGikdA/p.jpeg",
                            StartDate = DateTime.Now,
                            Description = "luxary"
                        },

                    });
                    context.SaveChanges();
                }

                //CarManafacturers
                if (!context.CarManufacturers.Any())
                {
                    context.CarManufacturers.AddRange(new List<CarManufacturer>()
                    {
                        new CarManufacturer()
                        {
                            Name = "Porsche",
                            Description = "Sport cars",
                            Logo = "https://previews.dropbox.com/p/thumb/ABq2RofQV8CYMbQpU2he1qqauy_fYR2b5uc-xmNNCFQE5GXGx9QEOfbKwR404j6eIvDbgZ5dvBsfggngJ5ERhx9KMW4KDI3u-Zgrtf7jRP9Gz3ZHS-5_BGnK2613aZY2GOKh3mC_XZClQQTFa0LVec-jKVMk7Lq2cApYKObnV9qrU8qCVsu_-1LPxfl0-mQv5tlAc2aaYRrzX4_0cJ1IgEU4Ia1-x8lgepdBjhIOMSkUz_Kdxy1eLaRkIdLGjPLJlgsmdzVLH_CBx0WNpHDe8mcf2TELzRfLk_UvZHZYWJEfF9Iin_32uZMSKWnWl5_u2MNwwoUH_tcInAXpR1zmLryES3QJ31EQN-_6aBLHfGvlYEcWUQ62BslIR3cbfUeWE6Y/p.jpeg",
                            FoundationDate = DateTime.Now.AddDays(-1300) ,  
                            CarCategory = CarCategory.Sport
                        },

                       new CarManufacturer()
                        {
                            Name = "Range Rover",
                            Description = "Land Rover",
                            Logo = "https://previews.dropbox.com/p/thumb/ABrMgYSNY1N5aV6gNlWNNC-8xz5IVOm3ZJCcvut2mxfaXS4pnSJ3ksvncQ0VoCLBKitcpIPndPl0VYvWvtEZMmfaEC8k9o0zIoWU535Fqu48w9-dtsZTaYsw93FgQSF6ZlJ5NhcrWcyBUCdoJk_7JoimvRYHMeYSbBCLhoDy9NxvPjw3qgyogO68eQwY1O9NKzt_Icmje79HPS5nplY-T5ME7e0p6vjdg55cEu_bZaHW-cLMQrUCQ6fUdf0IUvfYMPE-kxVP6Ou8Ml8DV3YJULozLGsgbBjdi-HPwwO3Px2WrtJo9Cdyj9KJYMePX3uto4Nuw60G62UAbTjC4DD66ePDLuaLjToSGXBAgjOPVYnXQnnXsmnobP_wWY0FFRvQ9X0/p.jpeg",
                            FoundationDate = DateTime.Now.AddDays(-1300),
                            CarCategory = CarCategory.SUV
                        },
                       new CarManufacturer()
                        {
                            Name = "Rolls Royce",
                            Description = "lux",
                            Logo = "https://previews.dropbox.com/p/thumb/ABq335r7BM3Cjn4i-EwGdHNwR8x5RMGrYg5v5PYT-4BVovxtuIoXTl2Tmb5bHwodZBH2MJAaMu90j1gXC0tIFTfWbfu7_699MjbR3SuB_fOYoXP4jDenP5ep5oWPxBiWdSuVvCJNsMPLdXcox6e5Y6PDA-i8J_cOiyPYkf40z6IQrdnnGb_oCVMEoxughG6Yp13VNAQhOQsIgqAUYLTDGOyUlKSXQsyYOeJUcPYFS_3bVJ9w-4znyBcrAzqmzEpe-7pvhruxuXE4u9VUgdFO0VHv9b38tPSNa2FBjb2-pRKoo13AqG7SBOLY41tZK0dHwxqd8n5i_L9MuQ1o4_faowOcjOM6kvD3qfZt8k37WyR3w9sgWhIrtXBHsT3CCWYRVAg/p.jpeg",
                            FoundationDate = DateTime.Now.AddDays(-1300),
                            CarCategory = CarCategory.Luxary
                        }

                    });
                    context.SaveChanges();
                }

                //Cars & Manafacturers
                if (!context.Cars_CarManufacturers.Any())
                {
                    context.Cars_CarManufacturers.AddRange(new List<Car_CarManufacturer>()
                    {
                        new Car_CarManufacturer()
                        {
                            CarId = 1,
                            CarmanId = 1
                        },
                        new Car_CarManufacturer()
                        {
                            CarId = 2,
                            CarmanId = 1
                        },
                        new Car_CarManufacturer()
                        {
                            CarId = 3,
                            CarmanId = 1
                        },
                         new Car_CarManufacturer()
                        {
                            CarId = 4,
                            CarmanId = 2
                        },
                        new Car_CarManufacturer()
                        {
                            CarId = 5,
                            CarmanId = 2
                        },
                        new Car_CarManufacturer()
                        {
                            CarId = 6,
                            CarmanId = 2,
                        },
                         new Car_CarManufacturer()
                        {
                            CarId = 7,
                            CarmanId = 3
                        },
                        new Car_CarManufacturer()
                        {
                            CarId = 8,
                            CarmanId = 3
                        },
                        new Car_CarManufacturer()
                        {
                            CarId = 9,
                            CarmanId = 3
                        },
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
