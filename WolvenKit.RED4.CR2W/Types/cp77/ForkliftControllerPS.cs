using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ForkliftControllerPS : ScriptableDeviceComponentPS
	{
		private ForkliftSetup _forkliftSetup;
		private CBool _isUp;

		[Ordinal(103)] 
		[RED("forkliftSetup")] 
		public ForkliftSetup ForkliftSetup
		{
			get => GetProperty(ref _forkliftSetup);
			set => SetProperty(ref _forkliftSetup, value);
		}

		[Ordinal(104)] 
		[RED("isUp")] 
		public CBool IsUp
		{
			get => GetProperty(ref _isUp);
			set => SetProperty(ref _isUp, value);
		}

		public ForkliftControllerPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
