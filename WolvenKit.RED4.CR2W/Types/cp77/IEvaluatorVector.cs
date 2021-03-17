using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class IEvaluatorVector : IEvaluator
	{
		private CEnum<EFreeVectorAxes> _freeAxes;
		private CBool _spill;

		[Ordinal(0)] 
		[RED("freeAxes")] 
		public CEnum<EFreeVectorAxes> FreeAxes
		{
			get => GetProperty(ref _freeAxes);
			set => SetProperty(ref _freeAxes, value);
		}

		[Ordinal(1)] 
		[RED("spill")] 
		public CBool Spill
		{
			get => GetProperty(ref _spill);
			set => SetProperty(ref _spill, value);
		}

		public IEvaluatorVector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
