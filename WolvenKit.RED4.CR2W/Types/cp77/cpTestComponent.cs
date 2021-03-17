using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class cpTestComponent : gameComponent
	{
		private CFloat _whatever;
		private CFloat _whateverIE;

		[Ordinal(4)] 
		[RED("whatever")] 
		public CFloat Whatever
		{
			get => GetProperty(ref _whatever);
			set => SetProperty(ref _whatever, value);
		}

		[Ordinal(5)] 
		[RED("whateverIE")] 
		public CFloat WhateverIE
		{
			get => GetProperty(ref _whateverIE);
			set => SetProperty(ref _whateverIE, value);
		}

		public cpTestComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
