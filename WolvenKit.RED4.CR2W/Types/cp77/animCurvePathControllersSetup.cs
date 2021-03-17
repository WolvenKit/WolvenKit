using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animCurvePathControllersSetup : CVariable
	{
		private CName _name;
		private CName _startControllerName;
		private CName _mainControllerName;
		private CName _stopControllerName;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("startControllerName")] 
		public CName StartControllerName
		{
			get => GetProperty(ref _startControllerName);
			set => SetProperty(ref _startControllerName, value);
		}

		[Ordinal(2)] 
		[RED("mainControllerName")] 
		public CName MainControllerName
		{
			get => GetProperty(ref _mainControllerName);
			set => SetProperty(ref _mainControllerName, value);
		}

		[Ordinal(3)] 
		[RED("stopControllerName")] 
		public CName StopControllerName
		{
			get => GetProperty(ref _stopControllerName);
			set => SetProperty(ref _stopControllerName, value);
		}

		public animCurvePathControllersSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
