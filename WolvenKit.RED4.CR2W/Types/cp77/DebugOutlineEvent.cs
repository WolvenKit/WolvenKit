using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DebugOutlineEvent : redEvent
	{
		private CEnum<EOutlineType> _type;
		private CFloat _opacity;
		private entEntityID _requester;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<EOutlineType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<EOutlineType>) CR2WTypeManager.Create("EOutlineType", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("opacity")] 
		public CFloat Opacity
		{
			get
			{
				if (_opacity == null)
				{
					_opacity = (CFloat) CR2WTypeManager.Create("Float", "opacity", cr2w, this);
				}
				return _opacity;
			}
			set
			{
				if (_opacity == value)
				{
					return;
				}
				_opacity = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("requester")] 
		public entEntityID Requester
		{
			get
			{
				if (_requester == null)
				{
					_requester = (entEntityID) CR2WTypeManager.Create("entEntityID", "requester", cr2w, this);
				}
				return _requester;
			}
			set
			{
				if (_requester == value)
				{
					return;
				}
				_requester = value;
				PropertySet(this);
			}
		}

		public DebugOutlineEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
