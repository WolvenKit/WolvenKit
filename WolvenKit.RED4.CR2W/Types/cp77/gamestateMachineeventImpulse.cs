using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineeventImpulse : gamestateMachineeventBaseEvent
	{
		private Vector4 _impulse;

		[Ordinal(1)] 
		[RED("impulse")] 
		public Vector4 Impulse
		{
			get
			{
				if (_impulse == null)
				{
					_impulse = (Vector4) CR2WTypeManager.Create("Vector4", "impulse", cr2w, this);
				}
				return _impulse;
			}
			set
			{
				if (_impulse == value)
				{
					return;
				}
				_impulse = value;
				PropertySet(this);
			}
		}

		public gamestateMachineeventImpulse(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
