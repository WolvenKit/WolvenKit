using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkanimRotationInterpolator : inkanimInterpolator
	{
		private CFloat _startValue;
		private CFloat _endValue;
		private CBool _goShortPath;

		[Ordinal(7)] 
		[RED("startValue")] 
		public CFloat StartValue
		{
			get => GetProperty(ref _startValue);
			set => SetProperty(ref _startValue, value);
		}

		[Ordinal(8)] 
		[RED("endValue")] 
		public CFloat EndValue
		{
			get => GetProperty(ref _endValue);
			set => SetProperty(ref _endValue, value);
		}

		[Ordinal(9)] 
		[RED("goShortPath")] 
		public CBool GoShortPath
		{
			get => GetProperty(ref _goShortPath);
			set => SetProperty(ref _goShortPath, value);
		}

		public inkanimRotationInterpolator(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
