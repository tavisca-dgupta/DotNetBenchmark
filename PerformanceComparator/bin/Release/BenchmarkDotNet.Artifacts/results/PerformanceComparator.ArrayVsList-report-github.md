``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17134.885 (1803/April2018Update/Redstone4)
Intel Core i7-6600U CPU 2.60GHz (Skylake), 1 CPU, 4 logical and 2 physical cores
Frequency=2742193 Hz, Resolution=364.6716 ns, Timer=TSC
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 32bit LegacyJIT-v4.7.3416.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 32bit LegacyJIT-v4.7.3416.0


```
|           Method | countNumber |     Mean |     Error |    StdDev |
|----------------- |------------ |---------:|----------:|----------:|
| AddNumberInArray |          50 | 43.80 ns | 0.5578 ns | 0.5218 ns |
|  AddNumberInList |          50 |       NA |        NA |        NA |

Benchmarks with issues:
  ArrayVsList.AddNumberInList: DefaultJob [countNumber=50]
