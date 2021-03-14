using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DismembermentDebrisEvent : redEvent
	{
		private CString _resourcePath;
		private CFloat _strength;

		[Ordinal(0)] 
		[RED("resourcePath")] 
		public CString ResourcePath
		{
			get
			{
				if (_resourcePath == null)
				{
					_resourcePath = (CString) CR2WTypeManager.Create("String", "resourcePath", cr2w, this);
				}
				return _resourcePath;
			}
			set
			{
				if (_resourcePath == value)
				{
					return;
				}
				_resourcePath = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("strength")] 
		public CFloat Strength
		{
			get
			{
				if (_strength == null)
				{
					_strength = (CFloat) CR2WTypeManager.Create("Float", "strength", cr2w, this);
				}
				return _strength;
			}
			set
			{
				if (_strength == value)
				{
					return;
				}
				_strength = value;
				PropertySet(this);
			}
		}

		public DismembermentDebrisEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
