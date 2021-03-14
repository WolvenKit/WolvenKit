using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkIEffect : ISerializable
	{
		private CBool _isEnabled;
		private CName _effectName;

		[Ordinal(0)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get
			{
				if (_isEnabled == null)
				{
					_isEnabled = (CBool) CR2WTypeManager.Create("Bool", "isEnabled", cr2w, this);
				}
				return _isEnabled;
			}
			set
			{
				if (_isEnabled == value)
				{
					return;
				}
				_isEnabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("effectName")] 
		public CName EffectName
		{
			get
			{
				if (_effectName == null)
				{
					_effectName = (CName) CR2WTypeManager.Create("CName", "effectName", cr2w, this);
				}
				return _effectName;
			}
			set
			{
				if (_effectName == value)
				{
					return;
				}
				_effectName = value;
				PropertySet(this);
			}
		}

		public inkIEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
