using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkanimDefinition : IScriptable
	{
		private CArray<CHandle<inkanimInterpolator>> _interpolators;
		private CArray<CHandle<inkanimEvent>> _events;

		[Ordinal(0)] 
		[RED("interpolators")] 
		public CArray<CHandle<inkanimInterpolator>> Interpolators
		{
			get
			{
				if (_interpolators == null)
				{
					_interpolators = (CArray<CHandle<inkanimInterpolator>>) CR2WTypeManager.Create("array:handle:inkanimInterpolator", "interpolators", cr2w, this);
				}
				return _interpolators;
			}
			set
			{
				if (_interpolators == value)
				{
					return;
				}
				_interpolators = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("events")] 
		public CArray<CHandle<inkanimEvent>> Events
		{
			get
			{
				if (_events == null)
				{
					_events = (CArray<CHandle<inkanimEvent>>) CR2WTypeManager.Create("array:handle:inkanimEvent", "events", cr2w, this);
				}
				return _events;
			}
			set
			{
				if (_events == value)
				{
					return;
				}
				_events = value;
				PropertySet(this);
			}
		}

		public inkanimDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
