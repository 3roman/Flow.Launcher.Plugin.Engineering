using System.Runtime.InteropServices;

namespace Flow.Launcher.Plugin.Engineering.IAPWS_IF97
{
    public class IF97
    {
        public static double PT2V(double p, double t)
        {
            return SEUIF97.seupt(p / 10, t, 3);
        }

        public static double PT2H(double p, double t)
        {
            return SEUIF97.seupt(p / 10, t, 4);
        }

        public static double PT2S(double p, double t)
        {
            return SEUIF97.seupt(p / 10, t, 5);
        }

        public static double PT2EX(double p, double t)
        {
            return SEUIF97.seupt(p / 10, t, 6);
        }

        public static double PT2CP(double p, double t)
        {
            return SEUIF97.seupt(p / 10, t, 8);
        }

        public static double PT2CV(double p, double t)
        {
            return SEUIF97.seupt(p / 10, t, 9);
        }

        public static double PT2W(double p, double t)
        {
            return SEUIF97.seupt(p / 10, t, 10);
        }

        public static double PT2KS(double p, double t)
        {
            return SEUIF97.seupt(p / 10, t, 11);
        }

        public static double PT2Z(double p, double t)
        {
            return SEUIF97.seupt(p / 10, t, 14);
        }

        public static double PT2X(double p, double t)
        {
            return SEUIF97.seupt(p / 10, t, 15);
        }

        public static double PT2R(double p, double t)
        {
            return SEUIF97.seupt(p / 10, t, 16);
        }

        public static double PT2JTC(double p, double t)
        {
            return SEUIF97.seupt(p / 10, t, 23);
        }

        public static double PT2DV(double p, double t)
        {
            return SEUIF97.seupt(p / 10, t, 24);
        }

        public static double PT2TC(double p, double t)
        {
            return SEUIF97.seupt(p / 10, t, 26) * 1000;
        }

        public static double PX2V(double p, double x)
        {
            return SEUIF97.seupx(p / 10, x, 3);
        }

        public static double PX2H(double p, double x)
        {
            return SEUIF97.seupx(p / 10, x, 4);
        }

        public static double PX2S(double p, double x)
        {
            return SEUIF97.seupx(p / 10, x, 5);
        }

        public static double PX2EX(double p, double x)
        {
            return SEUIF97.seupx(p / 10, x, 6);
        }

        public static double PX2CP(double p, double x)
        {
            return SEUIF97.seupx(p / 10, x, 8);
        }

        public static double PX2CV(double p, double x)
        {
            return SEUIF97.seupx(p / 10, x, 9);
        }

        public static double PX2W(double p, double x)
        {
            return SEUIF97.seupx(p / 10, x, 10);
        }

        public static double PX2KS(double p, double x)
        {
            return SEUIF97.seupx(p / 10, x, 11);
        }

        public static double PX2Z(double p, double x)
        {
            return SEUIF97.seupx(p / 10, x, 14);
        }

        public static double PX2T(double p, double x)
        {
            return SEUIF97.seupx(p / 10, x, 1);
        }

        public static double PX2R(double p, double x)
        {
            return SEUIF97.seupx(p / 10, x, 16);
        }

        public static double PX2JTC(double p, double x)
        {
            return SEUIF97.seupx(p / 10, x, 23);
        }

        public static double PX2DV(double p, double x)
        {
            return SEUIF97.seupx(p / 10, x, 24);
        }

        public static double PX2TC(double p, double x)
        {
            return SEUIF97.seupx(p / 10, x, 26);
        }

        public static double TX2V(double t, double x)
        {
            return SEUIF97.seutx(t, x, 3);
        }

        public static double TX2H(double t, double x)
        {
            return SEUIF97.seutx(t, x, 4);
        }

        public static double TX2S(double t, double x)
        {
            return SEUIF97.seutx(t, x, 5);
        }

        public static double TX2EX(double t, double x)
        {
            return SEUIF97.seutx(t, x, 6);
        }

        public static double TX2CP(double t, double x)
        {
            return SEUIF97.seutx(t, x, 8);
        }

        public static double TX2CV(double t, double x)
        {
            return SEUIF97.seutx(t, x, 9);
        }

        public static double TX2W(double t, double x)
        {
            return SEUIF97.seutx(t, x, 10);
        }

        public static double TX2KS(double t, double x)
        {
            return SEUIF97.seutx(t, x, 11);
        }

        public static double TX2Z(double t, double x)
        {
            return SEUIF97.seutx(t, x, 14);
        }

        public static double TX2P(double t, double x)
        {
            return SEUIF97.seutx(t, x, 0) * 10;
        }

        public static double TX2R(double t, double x)
        {
            return SEUIF97.seutx(t, x, 16);
        }

        public static double TX2JTC(double t, double x)
        {
            return SEUIF97.seutx(t, x, 23);
        }

        public static double TX2DV(double t, double x)
        {
            return SEUIF97.seutx(t, x, 24);
        }

        public static double TX2TC(double t, double x)
        {
            return SEUIF97.seutx(t, x, 26);
        }

        public static double PH2V(double p, double h)
        {
            return SEUIF97.seuph(p / 10, h, 3);
        }

        public static double PH2T(double p, double h)
        {
            return SEUIF97.seuph(p / 10, h, 1);
        }

        public static double PH2S(double p, double h)
        {
            return SEUIF97.seuph(p / 10, h, 5);
        }

        public static double PH2EX(double p, double h)
        {
            return SEUIF97.seuph(p / 10, h, 6);
        }

        public static double PH2CP(double p, double h)
        {
            return SEUIF97.seuph(p / 10, h, 8);
        }

        public static double PH2CV(double p, double h)
        {
            return SEUIF97.seuph(p / 10, h, 9);
        }

        public static double PH2W(double p, double h)
        {
            return SEUIF97.seuph(p / 10, h, 10);
        }

        public static double PH2KS(double p, double h)
        {
            return SEUIF97.seuph(p / 10, h, 11);
        }

        public static double PH2Z(double p, double h)
        {
            return SEUIF97.seuph(p / 10, h, 14);
        }

        public static double PH2X(double p, double h)
        {
            return SEUIF97.seuph(p / 10, h, 15);
        }

        public static double PH2R(double p, double h)
        {
            return SEUIF97.seuph(p / 10, h, 16);
        }

        public static double PH2JTC(double p, double h)
        {
            return SEUIF97.seuph(p / 10, h, 23);
        }

        public static double PH2DV(double p, double h)
        {
            return SEUIF97.seuph(p / 10, h, 24);
        }

        public static double PH2TC(double p, double h)
        {
            return SEUIF97.seuph(p / 10, h, 26) * 1000;
        }

        public static double PS2V(double p, double s)
        {
            return SEUIF97.seups(p / 10, s, 3);
        }

        public static double PS2T(double p, double s)
        {
            return SEUIF97.seups(p / 10, s, 1);
        }

        public static double PS2H(double p, double s)
        {
            return SEUIF97.seups(p / 10, s, 4);
        }

        public static double PS2EX(double p, double s)
        {
            return SEUIF97.seups(p / 10, s, 6);
        }

        public static double PS2CP(double p, double s)
        {
            return SEUIF97.seups(p / 10, s, 8);
        }

        public static double PS2CV(double p, double s)
        {
            return SEUIF97.seups(p / 10, s, 9);
        }

        public static double PS2W(double p, double s)
        {
            return SEUIF97.seups(p / 10, s, 10);
        }

        public static double PS2KS(double p, double s)
        {
            return SEUIF97.seups(p / 10, s, 11);
        }

        public static double PS2Z(double p, double s)
        {
            return SEUIF97.seups(p / 10, s, 14);
        }

        public static double PS2X(double p, double s)
        {
            return SEUIF97.seups(p / 10, s, 15);
        }

        public static double PS2R(double p, double s)
        {
            return SEUIF97.seups(p / 10, s, 16);
        }

        public static double PS2JTC(double p, double s)
        {
            return SEUIF97.seups(p / 10, s, 23);
        }

        public static double PS2DV(double p, double s)
        {
            return SEUIF97.seups(p / 10, s, 24);
        }

        public static double PS2TC(double p, double s)
        {
            return SEUIF97.seups(p / 10, s, 26) * 1000;
        }

        public static double HS2P(double h, double s)
        {
            return SEUIF97.seuhs(h, s, 0) * 10;
        }

        public static double HS2T(double h, double s)
        {
            return SEUIF97.seuhs(h, s, 1);
        }

        public static double HS2V(double h, double s)
        {
            return SEUIF97.seuhs(h, s, 3);
        }

        public static double HS2EX(double h, double s)
        {
            return SEUIF97.seuhs(h, s, 6);
        }

        public static double HS2CP(double h, double s)
        {
            return SEUIF97.seuhs(h, s, 8);
        }

        public static double HS2CV(double h, double s)
        {
            return SEUIF97.seuhs(h, s, 9);
        }

        public static double HS2W(double h, double s)
        {
            return SEUIF97.seuhs(h, s, 10);
        }

        public static double HS2KS(double h, double s)
        {
            return SEUIF97.seuhs(h, s, 11);
        }

        public static double HS2Z(double h, double s)
        {
            return SEUIF97.seuhs(h, s, 14);
        }

        public static double HS2X(double h, double s)
        {
            return SEUIF97.seuhs(h, s, 15);
        }

        public static double HS2R(double h, double s)
        {
            return SEUIF97.seuhs(h, s, 16);
        }

        public static double HS2JTC(double h, double s)
        {
            return SEUIF97.seuhs(h, s, 23);
        }

        public static double HS2DV(double h, double s)
        {
            return SEUIF97.seuhs(h, s, 24);
        }

        public static double HS2TC(double h, double s)
        {
            return SEUIF97.seuhs(h, s, 26) * 1000;
        }
    }

    public class SEUIF97
    {
        [DllImport("libseuif97")]
        public static extern double seupt(double p, double h, int wid);
        [DllImport("libseuif97")]
        public static extern double seuph(double p, double h, int wid);
        [DllImport("libseuif97")]
        public static extern double seups(double p, double s, int wid);
        [DllImport("libseuif97")]
        public static extern double seupv(double p, double v, int wid);
        [DllImport("libseuif97")]
        public static extern double seuth(double t, double h, int wid);
        [DllImport("libseuif97")]
        public static extern double seuts(double h, double s, int wid);
        [DllImport("libseuif97")]
        public static extern double seutv(double h, double v, int wid);
        [DllImport("libseuif97")]
        public static extern double seuhs(double h, double s, int wid);
        [DllImport("libseuif97")]
        public static extern double seupx(double p, double x, int wid);
        [DllImport("libseuif97")]
        public static extern double seutx(double h, double x, int wid);
        [DllImport("libseuif97")]
        public static extern double seuishd(double pi, double ti, double pe);
        [DllImport("libseuif97")]
        public static extern double seuief(double pi, double ti, double pe, double te);
    }
}
