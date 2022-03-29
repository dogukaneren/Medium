double malzemeNumarasi = await malzemeRepository.FirstOrDefaultAsync(x => 
    x.MalzemeNo.equals(malzemeNo)) + mazlemeEnumeration.Dayanikli.Value == MalzemeTuru ? 10000 : 0 + counter;