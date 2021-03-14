using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DistrictManager : IScriptable
	{
		private wCHandle<PreventionSystem> _system;
		private CArray<CHandle<District>> _stack;
		private CArray<TweakDBID> _visitedDistricts;

		[Ordinal(0)] 
		[RED("system")] 
		public wCHandle<PreventionSystem> System
		{
			get
			{
				if (_system == null)
				{
					_system = (wCHandle<PreventionSystem>) CR2WTypeManager.Create("whandle:PreventionSystem", "system", cr2w, this);
				}
				return _system;
			}
			set
			{
				if (_system == value)
				{
					return;
				}
				_system = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("stack")] 
		public CArray<CHandle<District>> Stack
		{
			get
			{
				if (_stack == null)
				{
					_stack = (CArray<CHandle<District>>) CR2WTypeManager.Create("array:handle:District", "stack", cr2w, this);
				}
				return _stack;
			}
			set
			{
				if (_stack == value)
				{
					return;
				}
				_stack = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("visitedDistricts")] 
		public CArray<TweakDBID> VisitedDistricts
		{
			get
			{
				if (_visitedDistricts == null)
				{
					_visitedDistricts = (CArray<TweakDBID>) CR2WTypeManager.Create("array:TweakDBID", "visitedDistricts", cr2w, this);
				}
				return _visitedDistricts;
			}
			set
			{
				if (_visitedDistricts == value)
				{
					return;
				}
				_visitedDistricts = value;
				PropertySet(this);
			}
		}

		public DistrictManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
