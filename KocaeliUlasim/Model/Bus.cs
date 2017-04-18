﻿namespace KocaeliUlasim.Model
{
    public class Bus
    {

        public string[] getBusList()
        {
            string[] array =
            {
                "10 UMUTTEPE-HALKEVİ-VALİLİK-SYMBOL A.V.M. / ULAŞIMPARK",
                "11 DOĞUKIŞLA-VALİLİK-İZMİT KENT 1/2/3-ERENLER / BELEDİYE",
                "13 ALİKAHYA - YUVAM AKARCA - D.BANKASI - UMUTTEPE / ULAŞIMPARK",
                "16 ERENLER-İZMİT KENT 1/2/3-VALİLİK-Y.KAPTAN-OTOGAR / BELEDİYE",
                "20 YUVAM AKARCA-OTOGAR-İZMİT-PLAJYOLU / ULAŞIMPARK",
                "22 BATI TERMİNALİ - YAHYA KAPTAN - OTOGAR / ÖHO",
                "23 YAHYA KAPTAN - UMUTTEPE / ÖHO",
                "24 SANAYİ - YAHYA KAPTAN - UMUTTEPE / ÖHO",
                "25 P.YOLU GARAJ - BEKİRPAŞA -YUVAM AKARCA - ÇOCUK HAS / ULAŞIMPARK",
                "26 ALİKAHYA - HAT-1 / ÖHO",
                "27 ALİKAHYA - HAT-2 / ÖHO",
                "28 ALİKAHYA - HAT-3 / ÖHO",
                "29 ALİKAHYA - HAT-4 / ÖHO",
                "32 ARIZLI-KENTKONUT-TÜYSÜZLER / ÖHO",
                "33 BATI TERMİNALİ - UMUTTEPE / ÖHO",
                "42 BAĞÇEŞME-KAYMAZ SOKAK / ÖHO",
                "43 GÜNEY TERMİNALİ - BAĞÇEŞME - UMUTTEPE / ÖHO",
                "44 GÜNEY TERMİNALİ - BAĞÇEŞME / ÖHO",
                "51 BATI TERMİNALİ - TOPÇULAR / ÖHO",
                "52 BATI TERMİNALİ-TOPÇULAR-TEPE ÜSTÜ-UMUTTEPE / ÖHO",
                "53 BATI TERMİNALİ - TOPÇULAR - UMUTTEPE / ÖHO",
                "55 BEYHAN - CUMHURİYET PARKI / ÖHO",
                "56 GÜLTEPE - YAHYA KAPTAN / ÖHO",
                "57 GÜLTEPE - BAÇ KAVŞAĞI / ÖHO",
                "59 TURGUT-TÜYSÜZLER- ÇAYIRKÖY-GÖLKENT / ÖHO",
                "64 CEZAEVİ -SANAYİ / ÖHO",
                "65 ORKİDE SOKAK - YENİDOĞAN - YUVAM AKARCA / BELEDİYE",
                "66 SEPETÇİ - SERDAR / ÖHO",
                "67 PLAJ YOLU OTOBÜS GARAJI - ÇUBUKLU - MANDIRA / BELEDİYE",
                "70 AKPINAR TOKİ-CUMHURİYET PARKI-BAYINDIRLIK-UMUTTEPE / ULAŞIMPARK",
                "73 ARIZLI YURT-YENİ MAH.-GÜLTEPE-UMUTTEPE / ÖHO",
                "76 KULFALLI - HACIOĞLU / ÖHO",
                "80 PLAJ YOLU-HALKEVİ-M.ALİ PAŞA-Y.KAPTAN-YUVAM AKARCA / ULAŞIMPARK",
                "81 GÜNDOĞDU - RADAR / ÖHO",
                "82 ÇENESUYU - BAYINDIRLIK / ÖHO",
                "83 UMUTTEPE - DÜNYA BANKASI / ÖHO",
                "85 AKPINAR TOKİ-KURU ÇEŞME-D.BANKASI-UMUTTEPE / ULAŞIMPARK",
                "87 ŞİRİNTEPE - BEKİRPAŞA / ÖHO",
                "88 DÜNYA BANKASI-AKPINAR TOKİ / ÖHO",
                "90 ŞİRİNTEPE-HALKEVİ-ÇAYIRKÖY-KANDIRA CEZAEVLERİ / ULAŞIMPARK",
                "91 PLAJ YOLU - BEKİRPAŞA / ÖHO",
                "92 BAYINDIRLIK-RABİA HATUN-ÇENESUYU / ÖHO",
                "93 AKPINAR TOKİ - ŞİRİNTEPE - MARİNA - UMUTTEPE / ÖHO",
                "94 42 EVLER - MERSİNCİK MAH. / ÖHO",
                "95 GÜNDOĞDU TOKİ - PLAJ YOLU / ÖHO",
                "96 PLAJ YOLU - YAHYA KAPTAN / ÖHO",
                "101 DERİNCE ŞEHİRİÇİ HAT-1 / ÖHO",
                "102 DERİNCE ŞEHİRİÇİ HAT-2 / ÖHO",
                "103 DERİNCE ŞEHİRİÇİ HAT-3 / ÖHO",
                "105 ÖĞRETMENLER-HALKEVİ-GÜNDOĞDU-UMUTTEPE / ULAŞIMPARK",
                "111 HARMANTARLA - ESENTEPE - TAVŞANTEPE / ÖHO",
                "115 KÖRFEZ KENT-SOPALI-DERİNCE-ÜÇYOL-UMUTTEPE / ULAŞIMPARK",
                "116 KÖRFEZ KENT-SOPALI-DERİNCE-HALKEVİ-YAHYA KAPTAN / ULAŞIMPARK",
                "118 YENİKENT - ÖĞRETMENLER - TERMİNAL / ÖHO",
                "120 SOPALI - DÜNYA BANKASI - BAYINDIRLIK / ÖHO",
                "121 SOPALI - BARIŞKENT - YAHYA KAPTAN / ÖHO",
                "123 KÖRFEZKENT - SOPALI - UMUTTEPE / ÖHO",
                "124 KÖRFEZ KENT-SOPALI-HALKEVİ-SANAYİ / ULAŞIMPARK",
                "126 SOPALI - YAHYA KAPTAN / ÖHO",
                "128 HARMANTARLA - TERMİNAL / ÖHO",
                "130 YENİKENT - DÜNYA BANKASI - BAYINDIRLIK / ÖHO",
                "133 SOPALI - UMUTTEPE / ÖHO",
                "134 YENİKENT - SANAYİ / ÖHO",
                "135 KÖRFEZKENT-YENİKENT-HALKEVİ-SANTRAL-Y.KAPTAN-YUVAM / ULAŞIMPARK",
                "138 YENİKENT - OTOGAR / ÖHO",
                "140 60 EVLER - OTOGAR / ÖHO",
                "141 60 EVLER - BEKİRPAŞA / ÖHO",
                "143 60 EVLER - UMUTTEPE / ÖHO",
                "145 60 EVLER-HALKEVİ-DÜNYA BANKASI-UMUTTEPE / ULAŞIMPARK",
                "147 HARMANTARLA - ÇINARLI - BEKİRPAŞA / ÖHO",
                "148 İSHAKÇILAR İZMİT / ÖHO",
                "149 TOYLAR - DERİNCE / ÖHO",
                "151 95 EVLER İZMİT / ÖHO",
                "152 ALTYOL YARIMCA İZMİT / ÖHO",
                "153 BÖLGE TRAFİK SANAYİ / ÖHO",
                "154 ÇAMLITEPE İZMİT / ÖHO",
                "155 KİRAZLIYALI ÇAMLITEPE YENİYALI SOPALI SANAYİ / ÖHO",
                "159 İLİMTEPE İZMİT / ÖHO",
                "160 KİRAZLIYALI - DERİNCE DEVLET / ÖHO",
                "161 KÖRFEZ ŞEHİRİÇİ RİNG / ÖHO",
                "163 İLİMTEPE-95 EVLER-İZMİT-OTOGAR / ULAŞIMPARK",
                "165 YARIMCA - DERİNCE DEVLET / ÖHO",
                "169 İLİMTEPE TÜTÜNÇİFTLİK / ÖHO",
                "170 KİRAZLIYALI-ALTYOL-İZMİT-UMUTTEPE / ULAŞIMPARK",
                "175 KİRAZLIYALI-ÇAMLITEPE-İZMİT-UMUTTEPE / ULAŞIMPARK",
                "176 SEVİNDİKLİ TÜTÜNÇİFTLİK / ÖHO",
                "177 ŞEMSETTİN TÜTÜNÇİFTLİK / ÖHO",
                "178 ALİHOCALAR TÜTÜNÇİFTLİK / ÖHO",
                "179 BALLIKÖY ( İLİMTEPE ) BELEN TÜTÜNÇİFTLİK / ÖHO",
                "181 AŞAĞI HEREKE - YUKARI HEREKE / ÖHO",
                "182 AŞAĞI HEREKE - KIŞLA DÜZÜ / ÖHO",
                "183 YUKARI HEREKE - İZMİT / ÖHO",
                "190 AŞAĞI HEREKE-KÖRFEZ-İZMİT-UMUTTEPE / ULAŞIMPARK",
                "191 HEREKE - İZMİT / ÖHO",
                "192 DİLOVASI - TAVŞANCIL - HEREKE - İZMİT / ÖHO",
                "195 YUKARI HEREKE-KÖRFEZ-İZMİT-UMUTTEPE / ULAŞIMPARK",
                "200 İZMİT- (KARTEPE) GEBZE-TUZLA-PENDİK-KARTAL METRO / ULAŞIMPARK",
                "201 ARSLANBEY MERKEZ / ÖHO",
                "202 ATAKENT İZMİT / ÖHO",
                "203 ARSLANBEY-İZMİT(ORTAK HAT) / ÖHO",
                "204 ARSLANBEY MERKEZ-TATŞEHİR-RAHMİYE-İZMİT / BELEDİYE",
                "205 BAHÇELİEVLER-ATA EVLERİ-İSTASYON-İZMİT / BELEDİYE",
                "210 KARTEPE BLD.- ALİKAHYA - BAYINDIRLIK - UMUTTEPE / BELEDİYE",
                "211 EMEKEVLER - İZMİT / ÖHO",
                "212 BAHÇELİEVLER - İZMİT / ÖHO",
                "213 İSTASYON - MYO -İZMİT / ÖHO",
                "214 TEPECİK - İZMİT / ÖHO",
                "215 MERKEZ HACIHALİM İZMİT / ÖHO",
                "216 UZUNBEY - İZMİT / ÖHO",
                "217 DUMLUPINAR - İZMİT / ÖHO",
                "218 SARIMEŞE İZMİT / ÖHO",
                "220 KÖSEKÖY MERKEZ-HACI HALİM-İZMİT / BELEDİYE",
                "221 AKMEŞE İZMİT / ÖHO",
                "222 ÜÇKÖYLER İZMİT / ÖHO",
                "223 BAYRAKTAR - ZEYTİNBURNU - GEDİKLİ İZMİT / ÖHO",
                "229 SULTANİYE İZMİT / ÖHO",
                "231 SARIMEŞE İZMİT / ÖHO",
                "232 TEPETARLA İZMİT / ÖHO",
                "235 BALABAN-DERBENT-ACISU-İZMİT / BELEDİYE",
                "240 İZMİT - TEPETARLA - ACISU - SEKA KAMPI / BELEDİYE",
                "241 ACISU İZMİT / ÖHO",
                "242 ŞİRİN SULHİYE İZMİT / ÖHO",
                "243 BALABAN İZMİT / ÖHO",
                "245 SUADİYE-EMEKEVLER-İSTASYON-İZMİT / BELEDİYE",
                "250 KÖRFEZ-İZMİT-OTOGAR-HAVAALANI / ULAŞIMPARK",
                "251 SUADİYE İZMİT / ÖHO",
                "255 SUADİYE-ARSLANBEY-RAHMİYE-UMUTTEPE / BELEDİYE",
                "260 MAŞUKİYE-ACISU-İSTASYON-İZMİT / BELEDİYE",
                "261 MAŞUKİYE MERKEZ İZMİT / ÖHO",
                "262 MAŞUKİYE ACISU İZMİT / ÖHO",
                "265 MAŞUKİYE - ACISU - U.ÇİFTLİK - KÖSEKÖY - UMUTTEPE / BELEDİYE",
                "267 EMİRHAN - BATI TERMİNALİ / ÖHO",
                "268 ESELER SOLAKLAR İZMİT / ÖHO",
                "269 BALÖREN İZMİT / ÖHO",
                "280 UMUTTEPE-U.ÇİFTLİK-KÖSEKÖY-UZUNTARLA-EŞME / BELEDİYE",
                "281 UZUNTARLA - BAĞDAT MAH. - İBRİKDERE - İZMİT / ÖHO",
                "282 UZUNTARLA - YEŞİLTEPE - MERKEZ - İZMİT / ÖHO",
                "285 EŞME-UZUNTARLA-İZMİT-UMUTTEPE / BELEDİYE",
                "286 KETENCİLER / ÖHO",
                "287 EŞME - İZMİT / ÖHO",
                "291 AVLUBURUN İZMİT / ÖHO",
                "297 KURTDERE AYVALI İZMİT / ÖHO",
                "298 HASANCIK ORTABURUN İZMİT / ÖHO",
                "299 KARTEPE RİNG HATTI / ÖHO",
                "300 DİLOVASI - KÖRFEZ - İZMİT - UMUTTEPE / ULAŞIMPARK",
                "301 FATİH DH-GEBZE-OTOGAR-TAVŞANCIL-HEREKE / ÖHO",
                "302 ÇERKEŞLİ-İMES-DİLOVASI-OTOGAR-GEBZE-FATİH DH / ÖHO",
                "303 DİLİSKELESİ-OTOGAR-K.SANAYİ-GEBZE-FATİH DH / ÖHO",
                "304 FATİH DH-GEBZE-OTOGAR-DİLOVASI-HASTANE-TAVŞANCIL / ÖHO",
                "305 DİLİSKELESİ-DİLOVASI-SOPALI HAST- İZMİT-UMUTTEPE / ULAŞIMPARK",
                "306 KAYMAKAMLIK-M.SİNAN-MUBECCEL Ç-HASTANE-TAVŞANCIL / ÖHO",
                "307 D.İSKELESİ-M.SİNAN-MÜBECCEL Ç.-HASTANE-TAVŞANCIL / ÖHO",
                "308 TAVŞANCIL-D 100-DİLOVASI-OTOGAR-GEBZE- FATİH DH / ÖHO",
                "309 FATİH DH-GEBZE-OTOGAR-DİLOVASI-M.SİNAN-KAYMAKAMLIK / ÖHO",
                "310 D.İSKELESİ-DİLOVASI-D100-DARICA-FARABİ D.HAST. / ULAŞIMPARK",
                "315 TAVŞANCIL-DİLOVASI HS-OTOGAR-TATLIKUYU-FARABİ D.H / ULAŞIMPARK",
                "320 İMES-DİLOVASI-M.PAŞA CAMİ-S.G.K-KBB OTOBÜS GARAJI / ULAŞIMPARK",
                "325 D.İSKELESİ-M.PAŞA-A.SAPAĞI-SGK-KBB OTOBÜS GARAJI / ULAŞIMPARK",
                "395 DİLOVASI - HEREKE - KÖRFEZ - UMUTTEPE / BELEDİYE",
                "396 TEPECİK-KÖSELER-DEMİRCİLER-MAKİNA OSB-DİLOVASI / ÖHO",
                "397 TEPECİK - DEMİRCİLER - KÖSELER-TAVŞANLI-TERMİNAL / ÖHO",
                "398 ÇERKEŞLİ - DİLOVASI / ÖHO",
                "399 TEPECİK - KÖSELER - DEMİRCİLER - GEBZE / ÖHO",
                "400 OTOGAR - KÖRFEZ - GEBZE - ÇAYIROVA-DARICA / BELEDİYE",
                "401 GEBZE-İZMİT ( TEM ) / ÖHO",
                "402 GEBZE-DİLOVASI-İZMİT(D-100 ) / ÖHO",
                "403 İSTASYON-GEBZE / ÖHO",
                "404 GEBZE-ESKİHİSAR / ÖHO",
                "405 ÖZGÜNKENT-Ş.PINAR-ÇAYIROVA-GEBZE-İZMİT-UMUTTEPE / ULAŞIMPARK",
                "406 GAZİLER-İNÖNÜ-M.PAŞA-FATİH DH-İSTASYON-S.SÖĞÜTLER / ÖHO",
                "407 KİRAZPINAR-CEZAEVİ-GEBZE AND.-M.PAŞA-FATİH DH / ÖHO",
                "408 GENÇLİK CD-BELEDİYE-M.PAŞA-FATİH DH-ESKİHİSAR / ÖHO",
                "409 BARIŞ MH-ANİBAL AND-TÜBİTAK-ANİBAL-M.PAŞA-FATİH D / ÖHO",
                "410 EMLAK KNT-M.PAŞA-FATİH D.H-İSTASYON CD.-FARABİ D.H / ULAŞIMPARK",
                "411 EMLAK K-TAŞOCAK-CEZAEVİ-GEBZE AND.L-M.PAŞA-FATİH D / ÖHO",
                "412 BEŞEVLER- GEBZE / ÖHO",
                "413 M.TEPE-BEYLİKBAĞI-SARICAMİ-FATİH D-TERMİNAL-M.PAŞA / ÖHO",
                "414 M.TEPE-A.YAVUZ-M.SİNAN-EMLAK BANK-FATİH DH-M.PAŞA / ÖHO",
                "415 K.B.B GARAJ-EMEK MH-B.BAĞI-M.PAŞA-FARABİ DH / BELEDİYE",
                "416 A.ÇEŞME-BELEDİYE-M.PAŞA-FATİH D-İSTASYON-ESKİHİSAR / ÖHO",
                "417 İSTASYON(MARMARAY)-FATİH DH-S.ORHAN-İNÖNÜ-YENİKENT / ÖHO",
                "418 İSTASYON(MARMARAY)-FATİH DH-M.PAŞA-İNÖNÜ-YENİKENT / ÖHO",
                "419 FATİH DH-M.PAŞA-GAZİ İO-KOCATEPE CAMİ-MEVLANA PARK / ÖHO",
                "420 BARIŞ MH-TÜBİTAK-ANİBAL-İSTASYON CD-FARABİ DH / ULAŞIMPARK",
                "421 YAVUZ SELİM - GEBZE(ÇOLAKOĞLU İNŞAAT) / ÖHO",
                "422 Y.SELİM-ADLİYE-AKSE S-M.PAŞA C-İSTASYON(MARMARAY) / ÖHO",
                "423 DENİZLİ M.-MOLLAFENARİ-PELİTLİ M-GOSB-AKSE S-GEBZE / ÖHO",
                "424 MUDARLI-OVACIK-KADILLI-CUMAKÖY-MOLLAFENARİ-GEBZE / ÖHO",
                "425 K.B.B GARAJ-M.SİNAN-B.BAĞI-FARABİ D.H / BELEDİYE",
                "426 GEBZE-AKSE S.-GENÇLİK C-GÜZELLER OSB-GEPOSB-BALÇIK / ÖHO",
                "427 TEPEMANAYIR-ELBİZLİ-KARGALI-M.PAŞA-KARABAKKAL C. / ÖHO",
                "428 ELBİZLİ-HATİPLER-KARGALI-M.PAŞA-KARABAKKAL C. / ÖHO",
                "429 ARAPÇEŞME - GEBZE / ÖHO",
                "430 M.TEPE-ULUS-B.BAĞI-M.PAŞA-SGK-KBB OTOBÜS GARAJI / ULAŞIMPARK",
                "431 TATLIKUYU - GEBZE / ÖHO",
                "435 KBB OTOBÜS GARAJI-M.PAŞA-GEBZE-İZMİT-UMUTTEPE / ULAŞIMPARK",
                "440 Y.SELİM-M.PAŞA-FATİH D.H-İSTASYON CD-FARABİ DH. / ULAŞIMPARK",
                "480 EMLAK KONUT-M.PAŞA-BEYLİK BAĞI-YENİ MAH-KENT ÖNÜ / ULAŞIMPARK",
                "485 KENT ÖNÜ-YENİ MAH.-Ç.KENT-S.G.K-GOSB / ULAŞIMPARK",
                "490 MUALLİMKÖY-GEBZE-YENİ MH.-GEBZE TEKNİK ÜNİVERSİTES / BELEDİYE",
                "494 MUALLİMKÖY YURT-D100-YENİ MAH-GETÜ / ÖHO",
                "496 OTOGAR - GEBZE - SEVİNDİKLİ-İSHAKÇILAR (ÇAVUŞLU) / ÖHO",
                "497 BALÇIK-GAZİLER-GEBZE-OTOGAR / ÖHO",
                "498 MUALLİMKÖY YURT-S.ORHAN-GEBZE-OTOGAR / ÖHO",
                "499 TAVŞANLI - S.ORHAN - GEBZE -OTOGAR / ÖHO",
                "500 DARICA - GEBZE - HEREKE / ULAŞIMPARK",
                "501 B.OĞLU-OSMANGAZİ-DARICA-İSTASYON-FATİH D.H-GEBZE / ÖHO",
                "502 KENTÖNÜ-PİRİ REİS-DARICA-FARABİ DH-GEBZE-İNÖNÜ / ÖHO",
                "503 KENTÖNÜ-OSMANGAZİ-N.HATUN-İSTASYON-FATİH DH-GEBZE / ÖHO",
                "504 KENTÖNÜ-S.SÖĞÜTLER-K.KARABEKİR-FARABİ DH-DARICA / ÖHO",
                "505 B.OĞLU-ATATÜRK CD-DARICA -M.PAŞA-OTOGAR / ULAŞIMPARK",
                "506 DARICA-K.KARABEKİR-NENEHATUN-İSTASYON-TERMİNAL / ÖHO",
                "507 DARICA - FARABİ D.H. -NENEHATUN - İSTASYON / ÖHO",
                "508 B.OĞLU- İMKB-EREN SİTESİ-FARABİ DH-İSTASYON-GEBZE / ÖHO",
                "509 B.OĞLU- İMKB-EREN SİTESİ-ATATÜRK CD-İSTASYON-GEBZE / ÖHO",
                "510 DARICA-FARABİ D.HAST-FATİH D.H.-YENİ KENT-OSB / BELEDİYE",
                "515 TOSB-GAZİLER-M.PAŞA-ANİBAL-FARABİ D.H-DARICA / ULAŞIMPARK",
                "520 K.ÖNÜ-ÜNİVERSİTE-DARICA-FARABİ D.H-OTOGAR / ULAŞIMPARK",
                "525 K.ÖNÜ-ÜNİVERSİTE-N.HATUN-Ş.G.OKKAN CD-OTOGAR / ULAŞIMPARK",
                "530 DARICA-GEBZE-İZMİT-UMUTTEPE / ULAŞIMPARK",
                "550 ÖZGÜNKENT-Ş.PINAR-YENİ MH-FARABİ DH-DARICA / BELEDİYE",
                "551 ERİŞLER-BELEDİYE-YENİ MAH-FATİH DH-İBRAHİMAĞA CD / ÖHO",
                "552 ERİŞLER-BOSNA C-GEBZE MEZARLIK- AKSE SAPAĞI-M.PAŞA / ÖHO",
                "553 A.YAVUZ-BELEDİYE-EMLAK BANK KONUT-FATİH DH-GEBZE / ÖHO",
                "554 ADEM YAVUZ - FATİH TREN İST. / ÖHO",
                "555 A.YAVUZ-BELEDİYE-YENİ MH.-ANİBAL-OTOGAR / ULAŞIMPARK",
                "556 SGK-ÇAĞDAŞKENT-BELEDİYE-YENİ MAH-FATİH DH-M.PAŞA / ÖHO",
                "557 SGK-ÇAĞDAŞKENT-ÇİÇEKÇİLER-YENİ MH-FATİH DH-M.PAŞA / ÖHO",
                "558 ÇAĞDAŞKENT-AKSE-GÜZELTEPE KNT-M.PAŞA- FATİH D.H / ÖHO",
                "559 ÇAYIROVA - KAYMAKAMLIK (HAT 1) / ÖHO",
                "560 A.YAVUZ-BOSNA CD.-AKSE SAPAĞI-ANİBAL-OTOGAR / ULAŞIMPARK",
                "561 KAYMAKAMLIK-TOKİ-TAYSAD-BOSNA CD-BELEDİYE-YENİ MH. / ÖHO",
                "562 KAYMAKAMLIK-TOKİ-ÇAYIROVA-A.YAVUZ-D 100-GEBZE / ÖHO",
                "563 ÖZGÜNKENT-TOKİ-KAYMAKAMLIK-YENİKENT-M.PAŞA-FATİH D / ÖHO",
                "565 KBB OTOBÜS GARAJI-Ç.KENT-YENİ MH-ANİBAL-OTOGAR / ULAŞIMPARK",
                "570 KBB OTOBÜS GARAJI-ÇİÇEKÇİLER-YENİ MH-ANİBAL-OTOGAR / ULAŞIMPARK",
                "575 Ş.PINAR-ATATÜRK MH.-YENİ M-ANİBAL-OTOGAR / ULAŞIMPARK",
                "580 Ş.PINAR-KAYMAKAMLIK-YENİKENT-M.PAŞA-GEBZE OTOGAR / ULAŞIMPARK",
                "600 KULLAR - İZMİT - UMUTTEPE / BELEDİYE",
                "610 KULLAR-M.Y.O.-SANAYİ-İZMİT / BELEDİYE",
                "611 YÜKSEKOKUL - İZMİT / ÖHO",
                "612 KARTONSAN - İZMİT / ÖHO",
                "613 VEZİRÇİFTLİĞİ - İZMİT / ÖHO",
                "614 DOĞANTEPE - İZMİT / ÖHO",
                "615 KULLAR HAT5 - İZMİT / ÖHO",
                "616 KULLAR İLÇE İÇİ RİNG / ÖHO",
                "620 YUVACIK-TINAZTEPE-SANAYİ-İZMİT / BELEDİYE",
                "621 YUVACIK MERKEZ İZMİT / ÖHO",
                "622 YUVACIK TINAZTEPE İZMİT / ÖHO",
                "623 YUVACIK MERKEZ AYDINKENT / ÖHO",
                "624 YUVACIK İZMİT DİŞ FAKÜLTESİ IRAK KONUTLARI / ÖHO",
                "625 YUVACIK AYDINKENT - İZMİT ESKİYOL / ÖHO",
                "626 YUVACIK ÇATALDERE / ÖHO",
                "630 YUVACIK MERKEZ-AYDINKENT-SANAYİ-İZMİT-UMUTTEPE / BELEDİYE",
                "631 BAHÇECİK - İZMİT - ESKİ YOL / ÖHO",
                "632 BAHÇECİK - İZMİT - YENİ YOL / ÖHO",
                "633 YEŞİLKENT - İZMİT - ESKİ YOL / ÖHO",
                "634 YEŞİLKENT - İZMİT - YENİ YOL / ÖHO",
                "635 BAHÇECİK-YEŞİL KENT-SEYMEN-İZMİT-UMUTTEPE / BELEDİYE",
                "636 BAHÇECİK-SEYMEN-ESKİYOL-İZMİT / BELEDİYE",
                "640 DÖNGEL-ALTINKENT-ESKİYOL-İZMİT-GÜLTEPE-UMUTTEPE / BELEDİYE",
                "641 DÖNGEL - İZMİT ESKİ YOL / ÖHO",
                "642 DÖNGEL - İZMİT YENİ YOL / ÖHO",
                "643 KALICI KONUTLAR - ESKİ YOL İZMİT / ÖHO",
                "644 KALICI KONUTLAR - YENİ YOL İZMİT / ÖHO",
                "645 ALTINKENT-DÖNGEL-YENİYOL-İZMİT / BELEDİYE",
                "650 KİRAZLIKENT-YENİKÖY-İZMİT-UMUTTEPE / BELEDİYE",
                "651 YENİKÖY - İZMİT ESKİ YOL / ÖHO",
                "652 YENİKÖY - İZMİT YENİ YOL / ÖHO",
                "655 FERHADİYE - KİRAZLIKENT - SEYMEN - GÖLCÜK / ÖHO",
                "656 YENİKÖY - GÖLCÜK / ÖHO",
                "661 SEPETLİPINAR İZMİT ESKİ YOL / ÖHO",
                "662 SEPETLİPINAR İZMİT YENİ YOL / ÖHO",
                "665 KİRAZLIKENT-YENİKÖY-GÖLCÜK / BELEDİYE",
                "666 SEPETLİPINAR - GÖLCÜK / ÖHO",
                "670 YAZLIK - GÖLCÜK / BELEDİYE",
                "671 YAZLIK - GÖLCÜK / ÖHO",
                "672 YAZLIK YUVAM GÖLCÜK / ÖHO",
                "675 HİSAREYN - GÖLCÜK / BELEDİYE",
                "676 HİSAREYN - ESENTEPE - GÖLCÜK / ÖHO",
                "677 HİSAREYN - TAŞOCAKLARI - GÖLCÜK / ÖHO",
                "678 HİSAREYN - GÖLCÜK / ÖHO",
                "680 İHSANİYE-ÇİFTLİK-SEYMEN-YENİYOL-İZMİT / BELEDİYE",
                "681 İHSANİYE - HASTANE - FORD SAPAĞI - GÖLCÜK / ÖHO",
                "682 İHSANİYE - HASTANE - ULUCAMİ - GÖLCÜK / ÖHO",
                "683 DEVLET HASTANESİ - ULUCAMİ - GÖLCÜK / ÖHO",
                "684 DENİZEVLER - UYDUKENT- ÇİFTLİK - GÖLCÜK / ÖHO",
                "685 İHSANİYE-HASTANE-ULUCAMİ-GÖLCÜK / BELEDİYE",
                "692 İHSANİYE - İZMİT / ÖHO",
                "695 HİSAREYN MERKEZ-ESENTEPE-YAZLIK-İZMİT / BELEDİYE",
                "698 DOĞANTEPE-YUVACIK-SERDAR-YENİKÖY / BELEDİYE",
                "699 DİŞ FAKÜLTESİ-KULLAR-BAHÇECİK-YENİKÖY / BELEDİYE",
                "700 GÖLCÜK-ÇİFTLİK-SEYMEN-İZMİT / BELEDİYE",
                "701 GÖLCÜK ESKİ YOL - İZMİT / ÖHO",
                "702 GÖLCÜK YENİ YOL - İZMİT / ÖHO",
                "710 GÖLCÜK D.HASTANESİ-ŞİRİNKÖY-SARAYLI-ESKİYOL-İZMİT / ULAŞIMPARK",
                "711 GÖLCÜK ŞEHİRİÇİ HAT-1 / ÖHO",
                "712 GÖLCÜK ŞEHİRİÇİ HAT-2 / ÖHO",
                "713 GÖLCÜK ŞEHİRİÇİ HAT-3 / ÖHO",
                "714 GÖLCÜK ŞEHİRİÇİ HAT-4 / ÖHO",
                "715 GÖLCÜK ŞEHİRİÇİ HAT-5 / ÖHO",
                "716 GÖLCÜK ŞEHİRİÇİ HAT-6 / ÖHO",
                "717 GÖLCÜK ŞEHİRİÇİ HAT-7 / ÖHO",
                "718 GÖLCÜK ŞEHİRİÇİ HAT-8 / ÖHO",
                "720 ÖRCÜN-SARAYLI-GÖLCÜK DEVLET HASTANESİ / BELEDİYE",
                "721 DEĞİRMENDERE - İZMİT ESKİ YOL / ÖHO",
                "722 DEĞİRMENDERE - İZMİT YENİ YOL / ÖHO",
                "730 GÖLCÜK DEVLET HAST.-ŞİRİNKÖY-DÜZAĞAÇ-GÖLCÜK / BELEDİYE",
                "731 DEĞİRMENDERE - GÖLCÜK HAT1 / ÖHO",
                "732 DEĞİRMENDERE - GÖLCÜK HAT2 / ÖHO",
                "733 DEĞİRMENDERE - GÖLCÜK / ÖHO",
                "738 AYVAZPINAR GÖLCÜK / ÖHO",
                "739 SENAİYE GÖLCÜK / ÖHO",
                "740 DEĞİRMENDERE-GÖLCÜK-ESKİYOL-İZMİT / BELEDİYE",
                "741 MAHMURİYE GÖLCÜK / ÖHO",
                "742 HASANEYN NİMETİYE GÖLCÜK / ÖHO",
                "743 NUSHETİYE - GÖLCÜK / ÖHO",
                "744 MESRURİYE İCADİYE AYVAZPINAR ŞEVKATİYE GÖLCÜK / ÖHO",
                "745 SOFULAR GÖLCÜK / ÖHO",
                "746 LÜTFİYE GÖLCÜK / ÖHO",
                "747 HAMİDİYE GÖLCÜK / ÖHO",
                "748 SELİMİYE GÖLCÜK / ÖHO",
                "749 SİRETİYE GÖLCÜK / ÖHO",
                "750 KARAMÜRSEL-GÖLCÜK-YENİYOL-İZMİT / BELEDİYE",
                "751 KARAMÜRSEL - İZMİT ESKİ YOL / ÖHO",
                "752 KARAMÜRSEL - İZMİT YENİ YOL / ÖHO",
                "753 DEREKÖY - KARAMÜRSEL - İZMİT / ÖHO",
                "755 KARAMÜRSEL - GÖLCÜK - BAŞİSKELE - UMUTTEPE / ULAŞIMPARK",
                "756 KARAMÜRSEL - UMUTTEPE / ÖHO",
                "761 KARAMÜRSEL ŞEHİRİÇİ HAT1 / ÖHO",
                "762 KARAMÜRSEL ŞEHİRİÇİ HAT2 - KENTKONUT / ÖHO",
                "763 KARAMÜRSEL ŞEHİRİÇİ HAT3 - DEREKÖY / ÖHO",
                "764 KARAMÜRSEL ŞEHİRİÇİ HAT4 - TEPEKÖY / ÖHO",
                "766 KARAMÜRSEL ŞEHİRİÇİ HAT5 - OLUKLU / ÖHO",
                "771 KARAMÜRSEL İZNİK / ÖHO",
                "772 KARAMÜRSEL - YALOVA / ÖHO",
                "781 KIZDERBENT KARAMÜRSEL / ÖHO",
                "782 YALAKDERE KARAMÜRSEL / ÖHO",
                "783 İNEBEYLİ TAŞAĞIL KARAMÜRSEL / ÖHO",
                "791 ÇAMÇUKUR KARAMÜRSEL / ÖHO",
                "792 PAZARKÖY KARAMÜRSEL / ÖHO",
                "793 AKÇAT KARAMÜRSEL / ÖHO",
                "794 KARAPINAR - KARAMÜRSEL / ÖHO",
                "796 OSMANİYE - EREĞLİ - KARAMÜRSEL / ÖHO",
                "797 TAHTALI - KARAMÜRSEL / ÖHO",
                "800 CEZAEVLERİ - KANDIRA - İZMİT / ULAŞIMPARK",
                "805 CEZAEVLERİ-Ş.SUNGUR-EĞERCİLİ-KARADİVAN-İZMİT / BELEDİYE",
                "811 KANDIRA - KARAAĞAÇ / ÖHO",
                "812 KANDIRA ŞEHİRİÇİ - YÜKSEKOKUL / ÖHO",
                "813 DEVLET HASTANESİ - İTFAİYE - AKÇAKAYRAN / ÖHO",
                "814 KANDIRA - DOĞANCILI - SARISU / ÖHO",
                "818 KERPE - KUMCAĞIZ - KANDIRA / ÖHO",
                "819 KANDIRA - KEFKEN - CEBECİ KÖYLER / ÖHO",
                "820 KANDIRA - KAYNARCA / ÖHO",
                "821 YUŞUFÇA - KANDIRA / ÖHO",
                "822 SARNIÇLAR - KANDIRA / ÖHO",
                "823 KARLIKÖYÜ - KANDIRA / ÖHO",
                "824 KANAATLAR-KANDIRA / ÖHO",
                "825 SEYİTALİLER-KANDIRA / ÖHO",
                "826 SARICAALİ-KANDIRA / ÖHO",
                "831 BAĞIRGANLI-KANDIRA / ÖHO",
                "832 ANTAPLI-KANDIRA / ÖHO",
                "833 ÇERÇİLİ-KANDIRA / ÖHO",
                "834 BEYLERBEYİ KANDIRA / ÖHO",
                "835 SAFALI-KANDIRA / ÖHO",
                "838 HACILAR-KANDIRA / ÖHO",
                "839 TAŞAMBAR-HEDİYELİ-KANDIRA-İZMİT / ÖHO",
                "841 BEYCE-KANDIRA-İZMİT / ÖHO",
                "842 KIRKARMUT-KANDIRA-İZMİT / ÖHO",
                "843 HACIŞEYH-KANDIRA-İZMİT / ÖHO",
                "844 GONCAAYDIN-KANDIRA-İZMİT / ÖHO",
                "845 EĞERCİLİ KANDIRA İZMİT / ÖHO",
                "847 ŞEREFSUNGUR KANDIRA İZMİT / ÖHO",
                "850 AĞVA AKÇAOVA KANDIRA İZMİT / ÖHO",
                "851 AKÇAOVA İZMİT / ÖHO",
                "852 AKÇAOVA KANDIRA / ÖHO",
                "857 TEKZEN İZMİT / ÖHO",
                "859 PINARLI KANDIRA / ÖHO",
                "866 ORHANİYE İZMİT / ÖHO",
                "871 SEPETÇİ KAYNARCA HORZUM TERZİLER İZMİT / ÖHO",
                "872 SADIKLAR NEBİHOCA GÖKÇEÖRE ŞAHİNLER GIRGIRLAR İZM / ÖHO",
                "873 BÖĞÜRGEN SÜVERLER ŞENTEPE ÜÇGAZİLER / ÖHO",
                "888 ARAMAN SELİMKÖY BAĞLICA İZMİT / ÖHO",
                "890 ARAMAN SELİMKÖY BAĞLICA ADAPAZARI / ÖHO",
                "891 ELMACI TOPLUCA KANDIRA İZMİT / ÖHO",
                "893 AKÇEKESE İZMİT / ÖHO",
                "711Ç GÖLCÜK ŞEHİRİÇİ HAT-1 / ÇARŞAMBA GÜNÜ / ÖHO",
                "712Ç GÖLCÜK ŞEHİRİÇİ HAT-2 / ÖHO",
                "713Ç GÖLCÜK ŞEHİRİÇİ HAT-3 / ÖHO",
                "714Ç GÖLCÜK ŞEHİRİÇİ HAT-4 / ÖHO",
                "715C GÖLCÜK ŞEHİRİÇİ HAT-5 ÇARŞAMBA / ÖHO",
                "715P GÖLCÜK ŞEHİRİÇİ HAT 5 / ÖHO",
                "716C GÖLCÜK ŞEHİRİÇİ HAT-6 / ÖHO",
                "716P GÖLCÜK ŞEHİRİÇİ HAT6 / ÖHO",
                "716Ç GÖLCÜK ŞEHİRİÇİ HAT-6 / ÖHO",
                "717P GÖLCÜK ŞEHİRİÇİ HAT-7 / ÖHO",
                "717Ç GÖLCÜK ŞEHİRİÇİ HAT-7 / ÖHO",
                "718P GÖLCÜK ŞEHİRİÇİ HAT-8 / ÖHO",
                "718Ç GÖLCÜK ŞEHİRİÇİ HAT-8 / ÖHO",
                "746Ç LÜTFİYE GÖLCÜK / ÖHO",
                "764C KARAMÜRSEL ŞEHİRİÇİ HAT4 TEPEKÖY CUMA / ÖHO",
                "793C AKÇAT KARAMÜRSEL / ÖHO",
                "831Ç BAĞIRGANLI KANDIRA ÇARŞAMBA / ÖHO",
                "832Ç ANTAPLI KANDIRA ÇARŞAMBA / ÖHO",
                "833Ç ÇERCİLİ KANDIRA ÇARŞAMBA / ÖHO",
                "834Ç BEYLERBEYİ KANDIRA ÇARŞAMBA / ÖHO",
                "835Ç SAFALI KANDIRA ÇARŞAMBA / ÖHO",
                "838Ç HACILAR KANDIRA ÇARŞAMBA / ÖHO",
                "839Ç TAŞAMBAR HEDİYELİ KANDIRA İZMİT ÇARŞAMBA / ÖHO",
                "842 K KIRKARMUT KANDIRA / ÖHO",
                "842Ç KIRKARMUT KANDIRA İZMİT ÇARŞAMBA / ÖHO",
                "843Ç HACIŞEYH KANDIRA İZMİT ÇARŞAMBA / ÖHO",
                "850Ç AĞVA AKÇAOVA KANDIRA İZMİT ÇARŞAMBA / ÖHO",
                "851Ç AKÇAOVA İZMİT ÇARŞAMBA / ÖHO",
                "857K TEKZEN KANDIRA / ÖHO",
                "888K ARAMAN SELİMKÖY BAĞLICA KANDIRA / ÖHO",
                "891Ç ELMACI TOPLUCA KANDIRA İZMİT ÇARŞAMBA / ÖHO",
                "D1 SANAYİ - MEHMET ALİ PAŞA / BELEDİYE",
                "D2 ESENTEPE - MEHMET ALİ PAŞA / BELEDİYE",
                "D3 HAVAALANI-SANAYİ-YENİKÖY-UMUTTEPE / ÖHO",
                "D4 BAYINDIRLIK - GÜNDOĞDU / BELEDİYE",
                "D5 SEPETÇİLER - CEZAEVİ / ÖHO",
                "S1 ALİKAHYA SERVİS / BELEDİYE",
                "S3 DERİNCE PERSONEL SERVİS / BELEDİYE",
                "S4 BAHÇEKENT / BELEDİYE"
            };
            return array;
        }
       
    }
}

