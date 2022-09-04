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
                            ProfilePictureUrl = "https://previews.dropbox.com/p/thumb/ABoLoiFLbvBD4b5uDBtiOFE_F0glzPPFWE0cnHt9qcOAGw89av60O-rdGHSHsavbaIJxhBzKuCz5TIN09vHaD12dwninQ26G14bNXq1HK-xpdnAz5MvGI6IeILg0f1k6aHcIDlMvhR07xoAEMCcA6uPKNQgRdJwXPfEg9M4svejD9YymhbhQh_WzM8tMbJTz5jwNzw1fs22D_ScmF6hs7WeZEwUTrsIe2ss3qwhhkiq-vltZGhuNDca8BGGnjz_yE2zPa2iTpXDhYpSIFKaNs5pDlikyeZ9y6pL6BLhnS4p01Fi3HygIYUpxZ5jElKY-ijUiDgzJCwtYfepli2cBdbWq0gtgJqtGQekwCP26cJbDwSAKcDTZW1SqkZlNBOEN0P8/p.jpeg",
                            StartDate = DateTime.Now.AddDays(-200),
                            Description = "luxary"
                        },
                        new Car()
                        {
                            CarName = "Cayenne GT",
                            ProfilePictureUrl = "https://previews.dropbox.com/p/thumb/ABqErh9wfVRfX-_tAD-Gp4ppC6VirMwqwkURzX6x8weKWNnuVB6atdaYGd5ybYSZ-X5Fz31__0qeChvlrGTLf7JeGGl9t9N6ehP7w32n2ZpFJsPibb-6kAn0EidPPQc0APSfJQxEJIKxp07uiVgUaghwUWGgyUvjfb68jZ_Y9HBpHePRGviZFC0ZGLno8Jx--PXrbkfenO6Put5hzj0HhP4cxNg9JXx0SGWbHSTKrH3jWz6aMwCV_5fxoopyGFxHbDUql3RcYtyxf5bTXaF81qNVbKFcZIQvfxoue1hG-xzwPuLcuDEHW5NMIYPuMaBt-C6jLS1DI1LMPsSBu0iwFrk8M1BaihFd31vS19sJ5JDlvRG4HR7bOmUQm5gKCy1goFfWfJc1PCSXLqcUc4s_QWXP/p.jpeg",
                            StartDate = DateTime.Now,
                            Description = "crossover"
                        },
                        new Car()
                        {
                            CarName = "911",
                            ProfilePictureUrl = "https://previews.dropbox.com/p/thumb/ABob_p96yP2ywxOTGxCj52pOShyRh8Q0zTuyr2jVJeXlTbcr1lhhtaneBR6J_aTDg8W8LezVXUKAo4KsyOs9X590TqLug3e7UcyrKuqCy58bae9UJkS7azmSf11K-xcxxxZndNGJ8OP8GGJ_KN-rFiBpAe-3Cvk3BupnSc70OE16YYg3HH7l-VpUmBWRI7Kle9qc1PQTTJE8vgwz4ELa_BAoaP4ydl8hUozFm5jE0aCQ8ZXViI0iC8nrJv1EWf09C8QlBLNCj4vl5ebXItYCQT1f8tmJup8rkdwG-PY2ZAa_9EcVuWRAx426YUtdJK3MfRk05I68kPEp65wJQYGjwggVd7NtMnCgmDXfMn474a6hnU-yUu2iwJ5bmJwTCtCOjNA/p.jpeg",
                            StartDate = DateTime.Now.AddDays(10),
                            Description = "sport"
                        },
                         new Car()
                        {
                            CarName = "RANGE ROVER SPORT",
                            ProfilePictureUrl = "https://previews.dropbox.com/p/thumb/ABpC392zzDt8GAGlqSM4zYKiJ2B0t6IrJ-a5_o-Wy4rPW5802GVroxkPumvWCySBFv5X3l8XnxYBBGSibcSqEA8D9WjRpMM5XhB_mwd0525Wasu3me9IfIHgE7te9AhZ9ojJUa_BUktc-GdEw5lRdTUXjBFun1R0xMJ7K25CWYi8V0KbOmnv6BvAzt6zYhdWgsUKuOXTcgGhUCk3ILpzMAjOO0m9dl8sDVrmr-QBHtEJssHrQm7fo085q_X9ypdAkocFI5G1C3L9t4V5e_OmEDIcoYmRSgVfIx1u5BCtAsvX3DmJQBdUX2Th95qJ8vfPTwTaxQ43-kqFMP847W7a3zCXGr5kvl_a8i8sA6ErarzRAxfy-aemd-afQB_J1NfAL8g/p.jpeg",
                            StartDate = DateTime.Now.AddDays(-200),
                            Description = "luxary"
                        },
                          new Car()
                        {
                            CarName = "RANGE ROVER VELAR",
                            ProfilePictureUrl = "https://previews.dropbox.com/p/thumb/ABpreFhD5GZ8VuYcwl7RhxD6sCAYBofgQSOHPGXAOMCjyP51QQ2ISTJnqsAkthQuoTRRqD5AvKpr-kyeECk6GUO2Y-OG5AhqWQMoziR8b8cC6h2FeLgVpNmfi828sYihr1u16yHOC8hk5dGjH_ZXCL2XGBFSJYVWo9g924_e3pRtjp4_-_C4RgbSwnsgCpiCN0U7uYg-tEpZWP4-W_XjV12iuhOogswu251QXq0Ajid-V9aKPD69TNKQei1kflEvlHL8nKlr7hsxXPeAjGrpKxpNQ5xBU1ttskwdOrDgEAt9UiKXQ7-5hlbsxR8eG9Se9XMY5gVf44DQXFYGdmoWqcsj6lMY19AOUvM-jCsDWDC9BIKjE8J9ebAbMbXi_T-IICY/p.jpeg",
                            StartDate = DateTime.Now.AddDays(-200),
                            Description = "luxary"
                        },
                           new Car()
                        {
                            CarName = "RANGE ROVER EVOQUE",
                            ProfilePictureUrl = "https://previews.dropbox.com/p/thumb/ABqaoemUwXhxDCyLtmojHL-E42phAuQ7XCTpVtB2FNdgwsy1naVG3kIj0KFmUukihGLJypqRpy7rP3QtS1Y1Y61yBxanAARTejlCLjf2hs1wYMsSHUw1W_OSxQdHdNDFi1NWnVsZVEFlP1S6SLug3oVscFifqOIxPh5ET5BjCqYfT0f84AQrKbYMfCh7GpCgy7oF_RWxBsVIA5uTExpRSmnOD49zVUGsf1rB1hYeMd0vUFoG643EZInwps5x0R122w1UBq07Jr7ZktRpDZpCDRY_BZGex2cr-G8-jRP40SC7psY8moKuG-zcrykbAgmv8DQUbumA7L7EFF_bcuSHr1fyCjwSmo96-cMKKwwZySGnOBGRMfcVEJAZZMRk8Gy5YctzszgcqNx6ba1D5Jq32I42/p.jpeg",
                            StartDate = DateTime.Now.AddDays(-200),
                            Description = "luxary"
                        },
                            new Car()
                        {
                            CarName = "Phantom",
                            ProfilePictureUrl = "https://previews.dropbox.com/p/thumb/ABq_NFsO49AhiUDat-I5ZMoxlk-ve7deZkxlfWW5x8sAQaALK5Y_UJvzFoUw7R1WfXiPPgroHVA0SWUEObMxEgrrD9D4zdcHg7atPkFX3yu1VZ6RILZltRseDKeJK19PwMsA7i9KemmDPDG0vVDOFDXs7zRtNqu4aMEiWmuwSeImVALTX5qc15RAvQ_3c1zQClKrhdxV6QHprJrJYo-C-d3ZGYj8aH6wMMIRaNoeZUZ5Ta090DdTZC1frUwKaTaTFPnOGRRxYgLmJh5kDASiSV-_tT_120SYLgJHZlMF9diadzYOKKPZXQh9USzWvXgXsYYDSxa_7LIg2GE99q4hJZ0l1kZpjTVCvlw_ZMcSmJJkml_FAVNCQPUXhypL9G0EsCg/p.jpeg",
                            StartDate = DateTime.Now,
                            Description = "luxary"
                        },
                             new Car()
                        {
                            CarName = "Ghost",
                            ProfilePictureUrl = "https://previews.dropbox.com/p/thumb/ABocd3Gmv2HnCSPYp8uAm5jcqOrs6MihE24QTG7yOyk3_O_CekRmWmtr1tNjTDubYCUqYNxO9mVgwqSbkb27zWxIKUAqbun6tnKOXI2vtJKXLKcYPzoS8egaMn3S9EPbNqHXpettI7ELt2-Zjdg1AaOBdgS6fiFFEX-LVKo6owD8RQDtLZ6dsluUlr4ZG0XDGllJnlJg7KXx_xXFW8NF3I1E2b7mdr8hBmjlRDFzEb9EYCW8c_v8UiPs5oZMPgnR8ZLsB7DCmoPnAaUMc3SzmIdoHqXin7z0ZHKlfb4KTw5Z_It80YDvrcKm7kdDbj2Tufyc611jJawWrlGKAbAaIz_t2CGC3dMTkXuIP779toqDcUk5qdVHr-Bu9-hxqpUnKaijT__L2w7Gj98tLEK1DcEI/p.jpeg",
                            StartDate = DateTime.Now,
                            Description = "luxary"
                        },
                              new Car()
                        {
                            CarName = "Spectre",
                            ProfilePictureUrl = "https://previews.dropbox.com/p/thumb/ABr1XtA3bazIKow9UI3xQgkKIrJSf6a3L-9xUqjP3eUXWdE4jGd5tnoos9Tb2DZmnbccK6_JE-53o1E226frffn0Ty-hLjj_K97kAfc6Qg9o15tJDxcrk9SH0VTBmR67FIeMyojg-rQNnpeTqTgOnI8kqVv1CYnoS2PHtJ7DI_Q4NlyndlJtwAlKa10Pn5G7vD7s6Z1aS8vpRTQlSbTk3V2nAqIbjAS9imgxoUqrnhhnnbbHmDqs72SPTMZwrUmLMLnZuDCPCbF98v7-e3PpQ3iXeSRDzeDCxXhcVcRCfQ_vN04RUsKm7MyhhVDFB7ysKPmNStBQqVhrFJ7bb1HV7d-KnDhLZaxFKFR-tIDh2CsoYQ_g3EE2ZkRfNIUpGLstBrxT1QjN-ToW4OgLcoaAt-4s/p.jpeg",
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
                            Logo = "https://previews.dropbox.com/p/thumb/ABrApU0jJTUin5beADAcoRgExwLrGsQ9P6VQ27eueGVzKSWZEweYGufNFw9gVLPFc4Pb5bR-fx4I3Y11Y7lZ4lwKeL0BUiz5sQXLK8Asbl5Prgzir6Ow-oJSz9BdlDmBcedEFVTsxTpvNgo6IaVK5TDM2LB9DucMcYIOvC4GIUxcx9hliIxU6MSLz-cZ-ITRecWKZsbr4pWjqyKmGciMKa3aqqJ4JapnxIm552I052BwK0l_sJx8DdasRcJY8t7dkrJiJdphp0Ww7nYHMA3JUYT6EWQT7E6ehxTdxQ7ENm1Jlo5ks5kOi7na7W_EM8-e7lSG34Yo3GgiuKssnhs9zXRmoMFlhcsFXFL064S3HajiyL0vufc-rSgqGyV-lQVqOyIImpspgM5Gql_bR3FHSLsE/p.jpeg",
                            FoundationDate = DateTime.Now.AddDays(-1300) ,  
                            CarCategory = CarCategory.Sport
                        },

                       new CarManufacturer()
                        {
                            Name = "Range Rover",
                            Description = "Land Rover",
                            Logo = "https://previews.dropbox.com/p/thumb/ABp7nr275xDueXaSO8x5BPgsr5EEp110q7oHArbpX8UwWRAqOXBS_uKL0uNG9tHhtvlSdChopKiDxlitd8F8ndtodhINsXVe6NjtBlqS-Jqz9DdzKfjeYxkaqXq-GHfcdHF09l5RuTQmQTUOjEss4Ja4ZG2mn6R2wTpZbR4qcZgZGRE7tRbDXYxTVJc8xTBura5sjnNX6SMr3RA4Q_SsdWj72L3y58FUBJ5vqLelxWh78qQ-LulxRJJkO1g9MQkH-68hgV0eEIOjZPmMFif04ZGgmm5H1GQWcs_dkMtr_zlJd_RdiS-ea3QXX9lG4PPncR-t7Cc3dhpd4W4WH5a5bdBmANrAzEUDNj1SPrZjYRExTYZ86QDjJ1Ne9uIpDo-eu0A/p.jpeg",
                            FoundationDate = DateTime.Now.AddDays(-1300),
                            CarCategory = CarCategory.SUV
                        },
                       new CarManufacturer()
                        {
                            Name = "Rolls Royce",
                            Description = "lux",
                            Logo = "https://previews.dropbox.com/p/thumb/ABof-bC4rEBGhkxWALroprsjLe2iNpViFSDb9AaB90LTvDGx09IYwytyDbK2xo300c5ou2a-UzYVBzVamnxZrCKXXa-sypN20wMLILYmlWne3Qi07KhCZNYnQZ1VwDdtb1UO1nyi3BuHM8m9xsx6oXWvxnzanrNjcUgeW42V87e1C2ZhwNADwuf1c0biefcf7_Qlpfy3c6GjSPfh7wttZZRkbCHNuw2GyOj1wWzaLXwYhhrMtWsgVU6Qc72OniZ_XgN9o5q9rZPS4Vgz67LvqahIaYb8HGDRPIbcIoIi8sJIhd79vyOgxIrKXJPV6EorSe0d2tmqafdH4R8Iv_pNHY8vqV-R34V2zhaEEYOFrW_W5jVzzqkvXsPXy-o-ZhbmHW4/p.jpeg",
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
