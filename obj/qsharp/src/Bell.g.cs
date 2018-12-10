#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"test_kyu\",\"Name\":\"ROL_64_128\"},\"SourceFile\":\"/home/kyu/Micro_Q/Quantum/Samples/src/QS_CHAM/test_kyu/Bell.qs\",\"Position\":{\"Item1\":12,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":20}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"k\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":22},\"Item2\":{\"Line\":1,\"Column\":23}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":31},\"Item2\":{\"Line\":1,\"Column\":32}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"Int\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"test_kyu\",\"Name\":\"ROL_64_128\"},\"SourceFile\":\"/home/kyu/Micro_Q/Quantum/Samples/src/QS_CHAM/test_kyu/Bell.qs\",\"Position\":{\"Item1\":12,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":20}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"test_kyu\",\"Name\":\"ROL1_64_128\"},\"SourceFile\":\"/home/kyu/Micro_Q/Quantum/Samples/src/QS_CHAM/test_kyu/Bell.qs\",\"Position\":{\"Item1\":17,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":21}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"k\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":23},\"Item2\":{\"Line\":1,\"Column\":24}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Int\"},\"ReturnType\":{\"Case\":\"Int\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"test_kyu\",\"Name\":\"ROL1_64_128\"},\"SourceFile\":\"/home/kyu/Micro_Q/Quantum/Samples/src/QS_CHAM/test_kyu/Bell.qs\",\"Position\":{\"Item1\":17,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":21}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"test_kyu\",\"Name\":\"ROL8_64_128\"},\"SourceFile\":\"/home/kyu/Micro_Q/Quantum/Samples/src/QS_CHAM/test_kyu/Bell.qs\",\"Position\":{\"Item1\":22,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":21}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"k\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":23},\"Item2\":{\"Line\":1,\"Column\":24}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Int\"},\"ReturnType\":{\"Case\":\"Int\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"test_kyu\",\"Name\":\"ROL8_64_128\"},\"SourceFile\":\"/home/kyu/Micro_Q/Quantum/Samples/src/QS_CHAM/test_kyu/Bell.qs\",\"Position\":{\"Item1\":22,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":21}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"test_kyu\",\"Name\":\"ROR_64_128\"},\"SourceFile\":\"/home/kyu/Micro_Q/Quantum/Samples/src/QS_CHAM/test_kyu/Bell.qs\",\"Position\":{\"Item1\":27,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":20}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"k\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":22},\"Item2\":{\"Line\":1,\"Column\":23}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":31},\"Item2\":{\"Line\":1,\"Column\":32}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"Int\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"test_kyu\",\"Name\":\"ROR_64_128\"},\"SourceFile\":\"/home/kyu/Micro_Q/Quantum/Samples/src/QS_CHAM/test_kyu/Bell.qs\",\"Position\":{\"Item1\":27,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":20}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"test_kyu\",\"Name\":\"KeyExpansion_64_128\"},\"SourceFile\":\"/home/kyu/Micro_Q/Quantum/Samples/src/QS_CHAM/test_kyu/Bell.qs\",\"Position\":{\"Item1\":32,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":29}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"k\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":30},\"Item2\":{\"Line\":1,\"Column\":31}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"test_kyu\",\"Name\":\"KeyExpansion_64_128\"},\"SourceFile\":\"/home/kyu/Micro_Q/Quantum/Samples/src/QS_CHAM/test_kyu/Bell.qs\",\"Position\":{\"Item1\":32,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":29}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"test_kyu\",\"Name\":\"Encryption_64_128\"},\"SourceFile\":\"/home/kyu/Micro_Q/Quantum/Samples/src/QS_CHAM/test_kyu/Bell.qs\",\"Position\":{\"Item1\":47,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":27}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"pt\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":28},\"Item2\":{\"Line\":1,\"Column\":30}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"rk\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":40},\"Item2\":{\"Line\":1,\"Column\":42}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"test_kyu\",\"Name\":\"Encryption_64_128\"},\"SourceFile\":\"/home/kyu/Micro_Q/Quantum/Samples/src/QS_CHAM/test_kyu/Bell.qs\",\"Position\":{\"Item1\":47,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":27}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"test_kyu\",\"Name\":\"CHAM_64x128\"},\"SourceFile\":\"/home/kyu/Micro_Q/Quantum/Samples/src/QS_CHAM/test_kyu/Bell.qs\",\"Position\":{\"Item1\":87,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"count\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":24},\"Item2\":{\"Line\":1,\"Column\":29}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"initial\"]},\"Type\":{\"Case\":\"Result\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":37},\"Item2\":{\"Line\":1,\"Column\":44}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Result\"}]]},\"ReturnType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"test_kyu\",\"Name\":\"CHAM_64x128\"},\"SourceFile\":\"/home/kyu/Micro_Q/Quantum/Samples/src/QS_CHAM/test_kyu/Bell.qs\",\"Position\":{\"Item1\":87,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"Documentation\":[]}")]
#line hidden
namespace test_kyu
{
    public class ROL_64_128 : Function<(Int64,Int64), Int64>, ICallable
    {
        public ROL_64_128(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64)>, IApplyData
        {
            public In((Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "ROL_64_128";
        String ICallable.FullName => "test_kyu.ROL_64_128";
        public override Func<(Int64,Int64), Int64> Body => (__in) =>
        {
            var (k,x) = __in;
#line 15 "/home/kyu/Micro_Q/Quantum/Samples/src/QS_CHAM/test_kyu/Bell.qs"
            return (((k << (int)x) | (k >> (int)(16L - x))) % 65536L);
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Int64 k, Int64 x)
        {
            return __m__.Run<ROL_64_128, (Int64,Int64), Int64>((k, x));
        }
    }

    public class ROL1_64_128 : Function<Int64, Int64>, ICallable
    {
        public ROL1_64_128(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "ROL1_64_128";
        String ICallable.FullName => "test_kyu.ROL1_64_128";
        public override Func<Int64, Int64> Body => (__in) =>
        {
            var k = __in;
#line 20 "/home/kyu/Micro_Q/Quantum/Samples/src/QS_CHAM/test_kyu/Bell.qs"
            return (((k << (int)1L) | (k >> (int)15L)) % 65536L);
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(Int64 data) => new QTuple<Int64>(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Int64 k)
        {
            return __m__.Run<ROL1_64_128, Int64, Int64>(k);
        }
    }

    public class ROL8_64_128 : Function<Int64, Int64>, ICallable
    {
        public ROL8_64_128(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "ROL8_64_128";
        String ICallable.FullName => "test_kyu.ROL8_64_128";
        public override Func<Int64, Int64> Body => (__in) =>
        {
            var k = __in;
#line 25 "/home/kyu/Micro_Q/Quantum/Samples/src/QS_CHAM/test_kyu/Bell.qs"
            return (((k << (int)8L) | (k >> (int)8L)) % 65536L);
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(Int64 data) => new QTuple<Int64>(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Int64 k)
        {
            return __m__.Run<ROL8_64_128, Int64, Int64>(k);
        }
    }

    public class ROR_64_128 : Function<(Int64,Int64), Int64>, ICallable
    {
        public ROR_64_128(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64)>, IApplyData
        {
            public In((Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "ROR_64_128";
        String ICallable.FullName => "test_kyu.ROR_64_128";
        public override Func<(Int64,Int64), Int64> Body => (__in) =>
        {
            var (k,x) = __in;
#line 30 "/home/kyu/Micro_Q/Quantum/Samples/src/QS_CHAM/test_kyu/Bell.qs"
            return (((k >> (int)x) | (k << (int)(16L - x))) % 65536L);
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Int64 k, Int64 x)
        {
            return __m__.Run<ROR_64_128, (Int64,Int64), Int64>((k, x));
        }
    }

    public class KeyExpansion_64_128 : Function<QArray<Int64>, QArray<Int64>>, ICallable
    {
        public KeyExpansion_64_128(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "KeyExpansion_64_128";
        String ICallable.FullName => "test_kyu.KeyExpansion_64_128";
        protected ICallable<(Int64,Int64), Int64> ROL_64_128
        {
            get;
            set;
        }

        public override Func<QArray<Int64>, QArray<Int64>> Body => (__in) =>
        {
            var k = __in;
#line 35 "/home/kyu/Micro_Q/Quantum/Samples/src/QS_CHAM/test_kyu/Bell.qs"
            var arr = new QArray<Int64>(16L);
#line 37 "/home/kyu/Micro_Q/Quantum/Samples/src/QS_CHAM/test_kyu/Bell.qs"
            foreach (var i in new Range(0L, 7L))
#line hidden
            {
#line 39 "/home/kyu/Micro_Q/Quantum/Samples/src/QS_CHAM/test_kyu/Bell.qs"
                arr[i] = ((k[i] ^ ROL_64_128.Apply((k[i], 1L))) ^ ROL_64_128.Apply((k[i], 8L)));
#line 40 "/home/kyu/Micro_Q/Quantum/Samples/src/QS_CHAM/test_kyu/Bell.qs"
                arr[((i + 8L) ^ 1L)] = ((k[i] ^ ROL_64_128.Apply((k[i], 1L))) ^ ROL_64_128.Apply((k[i], 11L)));
            }

#line 45 "/home/kyu/Micro_Q/Quantum/Samples/src/QS_CHAM/test_kyu/Bell.qs"
            return arr;
        }

        ;
        public override void Init()
        {
            this.ROL_64_128 = this.Factory.Get<ICallable<(Int64,Int64), Int64>>(typeof(ROL_64_128));
        }

        public override IApplyData __dataIn(QArray<Int64> data) => data;
        public override IApplyData __dataOut(QArray<Int64> data) => data;
        public static System.Threading.Tasks.Task<QArray<Int64>> Run(IOperationFactory __m__, QArray<Int64> k)
        {
            return __m__.Run<KeyExpansion_64_128, QArray<Int64>, QArray<Int64>>(k);
        }
    }

    public class Encryption_64_128 : Function<(QArray<Int64>,QArray<Int64>), QArray<Int64>>, ICallable
    {
        public Encryption_64_128(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Int64>,QArray<Int64>)>, IApplyData
        {
            public In((QArray<Int64>,QArray<Int64>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "Encryption_64_128";
        String ICallable.FullName => "test_kyu.Encryption_64_128";
        protected ICallable<(Int64,Int64), Int64> ROL_64_128
        {
            get;
            set;
        }

        public override Func<(QArray<Int64>,QArray<Int64>), QArray<Int64>> Body => (__in) =>
        {
            var (pt,rk) = __in;
#line 49 "/home/kyu/Micro_Q/Quantum/Samples/src/QS_CHAM/test_kyu/Bell.qs"
            var tmp = 0L;
#line 50 "/home/kyu/Micro_Q/Quantum/Samples/src/QS_CHAM/test_kyu/Bell.qs"
            var local_pt = new QArray<Int64>(4L);
#line 51 "/home/kyu/Micro_Q/Quantum/Samples/src/QS_CHAM/test_kyu/Bell.qs"
            var ct = new QArray<Int64>(4L);
#line 53 "/home/kyu/Micro_Q/Quantum/Samples/src/QS_CHAM/test_kyu/Bell.qs"
            foreach (var i in new Range(0L, 3L))
#line hidden
            {
#line 54 "/home/kyu/Micro_Q/Quantum/Samples/src/QS_CHAM/test_kyu/Bell.qs"
                local_pt[i] = pt[i];
            }

#line 57 "/home/kyu/Micro_Q/Quantum/Samples/src/QS_CHAM/test_kyu/Bell.qs"
            foreach (var i in new Range(0L, 19L))
#line hidden
            {
#line 59 "/home/kyu/Micro_Q/Quantum/Samples/src/QS_CHAM/test_kyu/Bell.qs"
                tmp = (ROL_64_128.Apply((local_pt[1L], 1L)) ^ rk[((4L * i) % 16L)]);
#line 60 "/home/kyu/Micro_Q/Quantum/Samples/src/QS_CHAM/test_kyu/Bell.qs"
                ct[0L] = (((local_pt[0L] ^ (4L * i)) + tmp) % 65536L);
#line 61 "/home/kyu/Micro_Q/Quantum/Samples/src/QS_CHAM/test_kyu/Bell.qs"
                ct[0L] = ROL_64_128.Apply((ct[0L], 8L));
#line 64 "/home/kyu/Micro_Q/Quantum/Samples/src/QS_CHAM/test_kyu/Bell.qs"
                tmp = (ROL_64_128.Apply((local_pt[2L], 8L)) ^ rk[(((4L * i) + 1L) % 16L)]);
#line 65 "/home/kyu/Micro_Q/Quantum/Samples/src/QS_CHAM/test_kyu/Bell.qs"
                ct[1L] = (((local_pt[1L] ^ ((4L * i) + 1L)) + tmp) % 65536L);
#line 66 "/home/kyu/Micro_Q/Quantum/Samples/src/QS_CHAM/test_kyu/Bell.qs"
                ct[1L] = ROL_64_128.Apply((ct[1L], 1L));
#line 69 "/home/kyu/Micro_Q/Quantum/Samples/src/QS_CHAM/test_kyu/Bell.qs"
                tmp = (ROL_64_128.Apply((local_pt[3L], 1L)) ^ rk[(((4L * i) + 2L) % 16L)]);
#line 70 "/home/kyu/Micro_Q/Quantum/Samples/src/QS_CHAM/test_kyu/Bell.qs"
                ct[2L] = (((local_pt[2L] ^ ((4L * i) + 2L)) + tmp) % 65536L);
#line 71 "/home/kyu/Micro_Q/Quantum/Samples/src/QS_CHAM/test_kyu/Bell.qs"
                ct[2L] = ROL_64_128.Apply((ct[2L], 8L));
#line 74 "/home/kyu/Micro_Q/Quantum/Samples/src/QS_CHAM/test_kyu/Bell.qs"
                tmp = (ROL_64_128.Apply((ct[0L], 8L)) ^ rk[(((4L * i) + 3L) % 16L)]);
#line 75 "/home/kyu/Micro_Q/Quantum/Samples/src/QS_CHAM/test_kyu/Bell.qs"
                ct[3L] = (((local_pt[3L] ^ ((4L * i) + 3L)) + tmp) % 65536L);
#line 76 "/home/kyu/Micro_Q/Quantum/Samples/src/QS_CHAM/test_kyu/Bell.qs"
                ct[3L] = ROL_64_128.Apply((ct[3L], 1L));
#line 79 "/home/kyu/Micro_Q/Quantum/Samples/src/QS_CHAM/test_kyu/Bell.qs"
                local_pt[0L] = ct[0L];
#line 80 "/home/kyu/Micro_Q/Quantum/Samples/src/QS_CHAM/test_kyu/Bell.qs"
                local_pt[1L] = ct[1L];
#line 81 "/home/kyu/Micro_Q/Quantum/Samples/src/QS_CHAM/test_kyu/Bell.qs"
                local_pt[2L] = ct[2L];
#line 82 "/home/kyu/Micro_Q/Quantum/Samples/src/QS_CHAM/test_kyu/Bell.qs"
                local_pt[3L] = ct[3L];
            }

#line 85 "/home/kyu/Micro_Q/Quantum/Samples/src/QS_CHAM/test_kyu/Bell.qs"
            return ct;
        }

        ;
        public override void Init()
        {
            this.ROL_64_128 = this.Factory.Get<ICallable<(Int64,Int64), Int64>>(typeof(ROL_64_128));
        }

        public override IApplyData __dataIn((QArray<Int64>,QArray<Int64>) data) => new In(data);
        public override IApplyData __dataOut(QArray<Int64> data) => data;
        public static System.Threading.Tasks.Task<QArray<Int64>> Run(IOperationFactory __m__, QArray<Int64> pt, QArray<Int64> rk)
        {
            return __m__.Run<Encryption_64_128, (QArray<Int64>,QArray<Int64>), QArray<Int64>>((pt, rk));
        }
    }

    public class CHAM_64x128 : Operation<(Int64,Result), (Int64,Int64,Int64,Int64)>, ICallable
    {
        public CHAM_64x128(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Result)>, IApplyData
        {
            public In((Int64,Result) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        public class Out : QTuple<(Int64,Int64,Int64,Int64)>, IApplyData
        {
            public Out((Int64,Int64,Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "CHAM_64x128";
        String ICallable.FullName => "test_kyu.CHAM_64x128";
        protected ICallable<String, QVoid> Message
        {
            get;
            set;
        }

        protected ICallable<(QArray<Int64>,QArray<Int64>), QArray<Int64>> Encryption_64_128
        {
            get;
            set;
        }

        protected ICallable<QArray<Int64>, QArray<Int64>> KeyExpansion_64_128
        {
            get;
            set;
        }

        public override Func<(Int64,Result), (Int64,Int64,Int64,Int64)> Body => (__in) =>
        {
            var (count,initial) = __in;
#line 90 "/home/kyu/Micro_Q/Quantum/Samples/src/QS_CHAM/test_kyu/Bell.qs"
            var key = new QArray<Int64>(256L, 770L, 1284L, 1798L, 2312L, 2826L, 3340L, 3854L);
#line 91 "/home/kyu/Micro_Q/Quantum/Samples/src/QS_CHAM/test_kyu/Bell.qs"
            var pt = new QArray<Int64>(4352L, 13090L, 21828L, 30566L);
#line 92 "/home/kyu/Micro_Q/Quantum/Samples/src/QS_CHAM/test_kyu/Bell.qs"
            var ct = new QArray<Int64>(4L);
#line 93 "/home/kyu/Micro_Q/Quantum/Samples/src/QS_CHAM/test_kyu/Bell.qs"
            var rk = new QArray<Int64>(16L);
#line 94 "/home/kyu/Micro_Q/Quantum/Samples/src/QS_CHAM/test_kyu/Bell.qs"
            Message.Apply("CHAM 64x128 Encyption");
#line 95 "/home/kyu/Micro_Q/Quantum/Samples/src/QS_CHAM/test_kyu/Bell.qs"
            rk = KeyExpansion_64_128.Apply(key);
#line 96 "/home/kyu/Micro_Q/Quantum/Samples/src/QS_CHAM/test_kyu/Bell.qs"
            ct = Encryption_64_128.Apply((pt?.Copy(), rk?.Copy()));
#line 98 "/home/kyu/Micro_Q/Quantum/Samples/src/QS_CHAM/test_kyu/Bell.qs"
            return (ct[0L], ct[1L], ct[2L], ct[3L]);
        }

        ;
        public override void Init()
        {
            this.Message = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Primitive.Message));
            this.Encryption_64_128 = this.Factory.Get<ICallable<(QArray<Int64>,QArray<Int64>), QArray<Int64>>>(typeof(Encryption_64_128));
            this.KeyExpansion_64_128 = this.Factory.Get<ICallable<QArray<Int64>, QArray<Int64>>>(typeof(KeyExpansion_64_128));
        }

        public override IApplyData __dataIn((Int64,Result) data) => new In(data);
        public override IApplyData __dataOut((Int64,Int64,Int64,Int64) data) => new Out(data);
        public static System.Threading.Tasks.Task<(Int64,Int64,Int64,Int64)> Run(IOperationFactory __m__, Int64 count, Result initial)
        {
            return __m__.Run<CHAM_64x128, (Int64,Result), (Int64,Int64,Int64,Int64)>((count, initial));
        }
    }
}