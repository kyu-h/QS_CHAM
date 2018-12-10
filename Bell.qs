namespace test_kyu
{
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Extensions.Math;
    open Microsoft.Quantum.Extensions.Convert;

    function ROL_64_128 (k : Int, x : Int) : (Int)
    {
        return ((k <<< x) ||| (k >>> 16-x)) % 0x10000;
    }

    function ROL1_64_128 (k : Int) : (Int)
    {
        return ((k <<< 1) ||| (k >>> 15)) % 0x10000;
    }

    function ROL8_64_128 (k : Int) : (Int)
    {
        return ((k <<< 8) ||| (k >>> 8)) % 0x10000;
    }

    function ROR_64_128 (k : Int, x : Int) : (Int)
    {
        return ((k >>> x) ||| ((k <<< 16-x))) % 0x10000;
    }

    function KeyExpansion_64_128(k : Int[]) : (Int[])
    {
        mutable arr = new Int[16];

        for (i in 0..8){
            set arr[i] = k[i] ^^^ ROL_64_128(k[i], 1) ^^^ ROL_64_128(k[i], 8);
            set arr[(i+8) ^^^ 0x0001] = k[i] ^^^ ROL_64_128(k[i], 1) ^^^ ROL_64_128(k[i], 11);
        }

        return arr;
    }

    function Encryption_64_128(pt : Int[], rk : Int[]) : (Int, Int, Int, Int){
        mutable tmp = 0;
        mutable ct = new Int[4];

        for (i in 0..20){
            set tmp = ROL_64_128(pt[1], 1) ^^^ rk[(4*i) % 16];
            set ct[0] = ((pt[0] ^^^ (4*i)) + tmp) % 0x10000;
            set ct[0] = ROL_64_128(ct[0], 8);

            set tmp = ROL_64_128(pt[2], 8) ^^^ rk[(4*i+1) % 16];
            set ct[1] = ((pt[1] ^^^ (4*i+1)) + tmp) % 0x10000;
            set ct[1] = ROL_64_128(ct[1], 1);

            set tmp = ROL_64_128(pt[3], 1) ^^^ rk[(4*i+2) % 16];
            set ct[2] = ((pt[2] ^^^ (4*i+2)) + tmp) % 0x10000;
            set ct[2] = ROL_64_128(ct[2], 8);

            set tmp = ROL_64_128(ct[0], 8) ^^^ rk[(4*i+3) % 16];
            set ct[3] = ((pt[3] ^^^ (4*i+3)) + tmp) % 0x10000;
            set ct[3] = ROL_64_128(ct[3], 1);
        }

        return (ct[0], ct[1], ct[2], ct[3]);
    }

    operation BellTest (count : Int, initial: Result) : (Int, Int, Int, Int)
    {
        mutable key = [0x0100, 0x0302, 0x0504, 0x0706, 0x0908, 0x0b0a, 0x0d0c, 0x0f0e];
        mutable ct = [0x1100, 0x3322, 0x5544, 0x7766];
        //mutable ct = new Int[4];
        mutable rk = new Int[16];

        //set pt = KeyExpansion_64_128(key);
        //set (ct[0], ct[1], ct[2], ct[3]) = Encryption_64_128(pt, rk);

        // Return number of times we saw a |0> and number of times we saw a |1>
        return (ct[0], ct[1], ct[2], ct[3]);
    }
}
