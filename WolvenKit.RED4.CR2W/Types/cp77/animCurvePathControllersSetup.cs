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
			get
			{
				if (_name == null)
				{
					_name = (CName) CR2WTypeManager.Create("CName", "name", cr2w, this);
				}
				return _name;
			}
			set
			{
				if (_name == value)
				{
					return;
				}
				_name = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("startControllerName")] 
		public CName StartControllerName
		{
			get
			{
				if (_startControllerName == null)
				{
					_startControllerName = (CName) CR2WTypeManager.Create("CName", "startControllerName", cr2w, this);
				}
				return _startControllerName;
			}
			set
			{
				if (_startControllerName == value)
				{
					return;
				}
				_startControllerName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("mainControllerName")] 
		public CName MainControllerName
		{
			get
			{
				if (_mainControllerName == null)
				{
					_mainControllerName = (CName) CR2WTypeManager.Create("CName", "mainControllerName", cr2w, this);
				}
				return _mainControllerName;
			}
			set
			{
				if (_mainControllerName == value)
				{
					return;
				}
				_mainControllerName = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("stopControllerName")] 
		public CName StopControllerName
		{
			get
			{
				if (_stopControllerName == null)
				{
					_stopControllerName = (CName) CR2WTypeManager.Create("CName", "stopControllerName", cr2w, this);
				}
				return _stopControllerName;
			}
			set
			{
				if (_stopControllerName == value)
				{
					return;
				}
				_stopControllerName = value;
				PropertySet(this);
			}
		}

		public animCurvePathControllersSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
