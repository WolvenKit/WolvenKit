using System;
using System.Collections.Generic;
using System.IO;

namespace SoundBankParser.Sections
{
    internal class HIRC_object
    {
        private readonly long offset;
        public uint id;
        public uint length;
        public byte[] remaining_data;
        public byte type;

        public HIRC_object(BinaryReader instream)
        {
            instream.BaseStream.Position -= 1;

            type = instream.ReadByte();
            length = instream.ReadUInt32();
            offset = instream.BaseStream.Position;
            id = instream.ReadUInt32();

            if (instream.BaseStream.Position - offset < length)
            {
                remaining_data = instream.ReadBytes((int) (length - (uint) (instream.BaseStream.Position - offset)));
            }
            else if (instream.BaseStream.Position - offset > length)
            {
                Console.WriteLine("HIRC_object - YOU READ TOO MUCH!!!");
            }
        }

        public void StreamWrite(BinaryWriter outstream)
        {
            outstream.Write(type);
            var newsizestart = outstream.BaseStream.Position;
            outstream.Write(length);
            outstream.Write(id);

            if (remaining_data != null)
                outstream.Write(remaining_data);

            //update section size
            var newsizeend = outstream.BaseStream.Position;
            outstream.BaseStream.Position = newsizestart;
            outstream.Write((uint) (newsizeend - (newsizestart + 4)));

            outstream.BaseStream.Position = newsizeend;
        }

        public override string ToString()
        {
            return "HIRC Object [ " +
                   "type: " + type + " " +
                   "length: " + length + " " +
                   "offset: " + offset + " " +
                   "id: " + id + " " +
                   (remaining_data != null ? " REMAINING DATA! " + remaining_data.Length + " bytes" : "") +
                   "]";
        }
    }

    internal class HIRC_Settings
    {
        private readonly long offset;
        public uint id;
        public uint length;
        public byte[] remaining_data;
        public byte settings_count;
        public List<byte> settings_voice = new List<byte>();
        public List<byte> settings_voice_value = new List<byte>();
        public byte type; //1

        public HIRC_Settings(BinaryReader instream)
        {
            instream.BaseStream.Position -= 1;

            type = instream.ReadByte();
            length = instream.ReadUInt32();
            offset = instream.BaseStream.Position;
            id = instream.ReadUInt32();
            settings_count = instream.ReadByte();
            for (var x = 0; x < settings_count; x++)
                settings_voice.Add(instream.ReadByte());
            for (var x = 0; x < settings_count; x++)
                settings_voice_value.Add(instream.ReadByte());


            if (instream.BaseStream.Position - offset < length)
            {
                remaining_data = instream.ReadBytes((int) (length - (uint) (instream.BaseStream.Position - offset)));
            }
            else if (instream.BaseStream.Position - offset > length)
            {
                Console.WriteLine("HIRC_Settings - YOU READ TOO MUCH!!!");
            }
        }

        public void StreamWrite(BinaryWriter outstream)
        {
            outstream.Write(type);
            var newsizestart = outstream.BaseStream.Position;
            outstream.Write(length);
            outstream.Write(id);
            outstream.Write(settings_count);
            foreach (var set_voice in settings_voice)
                outstream.Write(set_voice);
            foreach (var set_voice_val in settings_voice_value)
                outstream.Write(set_voice_val);

            if (remaining_data != null)
                outstream.Write(remaining_data);

            //update section size
            var newsizeend = outstream.BaseStream.Position;
            outstream.BaseStream.Position = newsizestart;
            outstream.Write((uint) (newsizeend - (newsizestart + 4)));

            outstream.BaseStream.Position = newsizeend;
        }

        public override string ToString()
        {
            return "HIRC Settings [ " +
                   "type: " + type + " " +
                   "length: " + length + " " +
                   "offset: " + offset + " " +
                   "id: " + id + " " +
                   "settings_count: " + settings_count + " " +
                   "settings_voice: " + settings_voice.Count + " " +
                   "settings_voice_value: " + settings_voice_value.Count + " " +
                   (remaining_data != null ? " REMAINING DATA! " + remaining_data.Length + " bytes" : "") +
                   "]";
        }
    }

    internal class HIRC_SoundSFX
    {
        private readonly long offset;
        public uint id;
        public uint length;
        public byte[] remaining_data;
        public uint soundid;
        public uint soundincluded; //0 = included, 1 = streamed, 2= streamed with prefetch
        public uint soundlength = uint.MaxValue; //if included //NOTE: MaxValue for debug, remove for release
        public uint soundoffset; //if included
        public uint soundsourceid;
        public byte soundtype; //00 = Sound SFX, 01 = Sound Voice
        public SoundStructure structure;
        public byte type; //2
        public uint unknownInt;

        public HIRC_SoundSFX(BinaryReader instream)
        {
            instream.BaseStream.Position -= 1;

            type = instream.ReadByte();
            length = instream.ReadUInt32();
            offset = instream.BaseStream.Position;
            id = instream.ReadUInt32();
            unknownInt = instream.ReadUInt32();
            soundincluded = instream.ReadUInt32();
            soundid = instream.ReadUInt32();
            soundsourceid = instream.ReadUInt32();
            if (soundincluded == 0)
            {
                soundoffset = instream.ReadUInt32();
                soundlength = instream.ReadUInt32();
            }
            soundtype = instream.ReadByte();
            //this.structure = new SoundStructure(instream);

            if (instream.BaseStream.Position - offset < length)
            {
                remaining_data = instream.ReadBytes((int) (length - (uint) (instream.BaseStream.Position - offset)));
            }
            else if (instream.BaseStream.Position - offset > length)
            {
                Console.WriteLine("HIRC_SoundSFX - YOU READ TOO MUCH!!!");
            }
        }

        public void StreamWrite(BinaryWriter outstream)
        {
            outstream.Write(type);
            var newsizestart = outstream.BaseStream.Position;
            outstream.Write(length);
            outstream.Write(id);
            outstream.Write(unknownInt);
            outstream.Write(soundincluded);
            outstream.Write(soundid);
            outstream.Write(soundsourceid);
            if (soundincluded == 0)
            {
                outstream.Write(soundoffset);
                outstream.Write(soundlength);
            }
            outstream.Write(soundtype);
            //outstream.Write(this.structure);

            if (remaining_data != null)
                outstream.Write(remaining_data);

            //update section size
            var newsizeend = outstream.BaseStream.Position;
            outstream.BaseStream.Position = newsizestart;
            outstream.Write((uint) (newsizeend - (newsizestart + 4)));

            outstream.BaseStream.Position = newsizeend;
        }

        public override string ToString()
        {
            return "HIRC SoundSFX [ " +
                   "type: " + type + " " +
                   "length: " + length + " " +
                   "offset: " + offset + " " +
                   "id: " + id + " " +
                   "unknownInt: " + unknownInt + " " +
                   "soundincluded: " + soundincluded + " " +
                   "soundid: " + soundid + " " +
                   "soundsourceid: " + soundsourceid + " " +
                   "soundoffset: " + soundoffset + " " +
                   "soundlength: " + soundlength + " " +
                   "soundtype: " + soundtype + " " +
                   //"SoundStructure: " + this.structure + " " +
                   (remaining_data != null ? " REMAINING DATA! " + remaining_data.Length + " bytes" : "") +
                   "]";
        }
    }

    internal class HIRC_EventAction
    {
        private readonly long offset;
        public byte actionType;
        public byte additionalParameters;
        public uint gameObjectID;
        public uint id;
        public uint length;
        public List<byte> parameterTypes = new List<byte>();
        public List<byte> parameterValues = new List<byte>();
        public byte[] remaining_data;
        public byte scope;
        public uint stateGroupId; // if actionType == 0x12 || 0x19
        public uint stateId; // if actionType == 0x12 || 0x19
        public byte type; //3
        public byte unknown1; //always 0
        public byte unknown2; //always 0

        public HIRC_EventAction(BinaryReader instream)
        {
            instream.BaseStream.Position -= 1;

            type = instream.ReadByte();
            length = instream.ReadUInt32();
            offset = instream.BaseStream.Position;
            id = instream.ReadUInt32();
            scope = instream.ReadByte();
            actionType = instream.ReadByte();
            gameObjectID = instream.ReadUInt32();
            unknown1 = instream.ReadByte();
            additionalParameters = instream.ReadByte();
            for (var x = 0; x < additionalParameters; x++)
                parameterTypes.Add(instream.ReadByte());
            for (var x = 0; x < additionalParameters; x++)
                parameterValues.Add(instream.ReadByte());
            unknown2 = instream.ReadByte();
            if (actionType == 0x12 || actionType == 0x19)
            {
                stateGroupId = instream.ReadUInt32();
                stateId = instream.ReadUInt32();
            }

            if (instream.BaseStream.Position - offset < length)
            {
                remaining_data = instream.ReadBytes((int) (length - (uint) (instream.BaseStream.Position - offset)));
            }
            else if (instream.BaseStream.Position - offset > length)
            {
                Console.WriteLine("HIRC_EventAction - YOU READ TOO MUCH!!!");
            }
        }

        public void StreamWrite(BinaryWriter outstream)
        {
            outstream.Write(type);
            var newsizestart = outstream.BaseStream.Position;
            outstream.Write(length);
            outstream.Write(id);
            outstream.Write(scope);
            outstream.Write(actionType);
            outstream.Write(gameObjectID);
            outstream.Write(unknown1);
            outstream.Write(additionalParameters);
            foreach (var paramtype in parameterTypes)
                outstream.Write(paramtype);
            foreach (var paramval in parameterValues)
                outstream.Write(paramval);
            outstream.Write(unknown2);
            if (actionType == 0x12 || actionType == 0x19)
            {
                outstream.Write(stateGroupId);
                outstream.Write(stateId);
            }

            if (remaining_data != null)
                outstream.Write(remaining_data);

            //update section size
            var newsizeend = outstream.BaseStream.Position;
            outstream.BaseStream.Position = newsizestart;
            outstream.Write((uint) (newsizeend - (newsizestart + 4)));

            outstream.BaseStream.Position = newsizeend;
        }

        public override string ToString()
        {
            return "HIRC EventAction [ " +
                   "type: " + type + " " +
                   "length: " + length + " " +
                   "offset: " + offset + " " +
                   "id: " + id + " " +
                   "scope: " + scope + " " +
                   "actionType: " + actionType + " " +
                   "gameObjectID: " + gameObjectID + " " +
                   "unknown1: " + unknown1 + " " +
                   "additionalParameters: " + additionalParameters + " " +
                   "parameterTypes: " + parameterTypes.Count + " " +
                   "parameterValues: " + parameterValues.Count + " " +
                   "unknown2: " + unknown2 + " " +
                   "stateGroupId: " + stateGroupId + " " +
                   "stateId: " + stateId + " " +
                   (remaining_data != null ? " REMAINING DATA! " + remaining_data.Length + " bytes" : "") +
                   "]";
        }
    }

    internal class HIRC_MusicTrack
    {
        private readonly long offset;
        public uint id;
        public uint length;
        public byte[] remaining_data;
        public uint soundID;
        public uint soundID2; //repeated.?
        public uint soundID3; //repeated.? for the third time? I get it. It's this ID. Stop repeating it.
        public double soundLength; //sound length in ms (1000 ms = 1 sec)
        public uint streamed; //? Seems to determine following positions
        public byte type; //11
        public byte[] unknown1; //8 unknown bytes
        public byte[] unknown2; //9 bytes if streamed == 1 AND 17 bytes if streamed == 2
        public byte[] unknown3; //24 unknown bytes

        public HIRC_MusicTrack(BinaryReader instream)
        {
            instream.BaseStream.Position -= 1;

            type = instream.ReadByte();
            length = instream.ReadUInt32();
            offset = instream.BaseStream.Position;
            id = instream.ReadUInt32();
            unknown1 = instream.ReadBytes(8);
            streamed = instream.ReadUInt32();
            soundID = instream.ReadUInt32();
            soundID2 = instream.ReadUInt32();
            if (streamed == 1)
                unknown2 = instream.ReadBytes(9);
            else if (streamed == 2)
                unknown2 = instream.ReadBytes(17);
            else
                unknown2 = instream.ReadBytes(8); //break here. I wanna see.
            soundID3 = instream.ReadUInt32();
            unknown3 = instream.ReadBytes(24);
            soundLength = instream.ReadDouble();

            if (instream.BaseStream.Position - offset < length)
            {
                remaining_data = instream.ReadBytes((int) (length - (uint) (instream.BaseStream.Position - offset)));
            }
            else if (instream.BaseStream.Position - offset > length)
            {
                Console.WriteLine("HIRC_MusicTrack - YOU READ TOO MUCH!!!");
            }
        }

        public void StreamWrite(BinaryWriter outstream)
        {
            outstream.Write(type);
            var newsizestart = outstream.BaseStream.Position;
            outstream.Write(length);
            outstream.Write(id);
            outstream.Write(unknown1);
            outstream.Write(streamed);
            outstream.Write(soundID);
            outstream.Write(soundID2);
            outstream.Write(unknown2);
            outstream.Write(soundID3);
            outstream.Write(unknown3);
            outstream.Write(soundLength);

            if (remaining_data != null)
                outstream.Write(remaining_data);

            //update section size
            var newsizeend = outstream.BaseStream.Position;
            outstream.BaseStream.Position = newsizestart;
            outstream.Write((uint) (newsizeend - (newsizestart + 4)));

            outstream.BaseStream.Position = newsizeend;
        }

        public override string ToString()
        {
            return "HIRC MusicTrack [ " +
                   "type: " + type + " " +
                   "length: " + length + " " +
                   "offset: " + offset + " " +
                   "id: " + id + " " +
                   "unknown1: " + unknown1.Length + " " +
                   "streamed: " + streamed + " " +
                   "soundID: " + soundID + " " +
                   "soundID2: " + soundID2 + " " +
                   "unknown2: " + unknown2.Length + " " +
                   "soundID3: " + soundID3 + " " +
                   "unknown3: " + unknown3.Length + " " +
                   "soundLength: " + soundLength + " " +
                   (remaining_data != null ? " REMAINING DATA! " + remaining_data.Length + " bytes" : "") +
                   "]";
        }
    }

    internal class HIRC_MusicSegment
    {
        private readonly long offset;
        public uint id;
        public uint length;
        public double looppoint1;
        public double looppoint2;
        public byte[] remaining_data;
        public SoundStructure soundstructure;
        public byte type; //10
        public byte[] unknown1;
        public byte[] unknown2;

        public HIRC_MusicSegment(BinaryReader instream)
        {
            instream.BaseStream.Position -= 1;

            type = instream.ReadByte();
            length = instream.ReadUInt32();
            offset = instream.BaseStream.Position;
            id = instream.ReadUInt32();
            soundstructure = new SoundStructure(instream);

            unknown1 = instream.ReadBytes(37);
            looppoint1 = instream.ReadDouble();
            unknown2 = instream.ReadBytes(24);
            looppoint2 = instream.ReadDouble();

            /*
            this.childObjectsCount = instream.ReadUInt32();
            for (int x = 0; x < this.childObjectsCount; x++)
                this.childObjects.Add(instream.ReadUInt32());
            */
            if (instream.BaseStream.Position - offset < length)
            {
                remaining_data = instream.ReadBytes((int) (length - (uint) (instream.BaseStream.Position - offset)));
            }
            else if (instream.BaseStream.Position - offset > length)
            {
                Console.WriteLine("HIRC_MusicSegment - YOU READ TOO MUCH!!!");
            }
        }

        public void StreamWrite(BinaryWriter outstream)
        {
            outstream.Write(type);
            var newsizestart = outstream.BaseStream.Position;
            outstream.Write(length);
            outstream.Write(id);
            soundstructure.StreamWrite(outstream);

            outstream.Write(unknown1);
            outstream.Write(looppoint1);
            outstream.Write(unknown2);
            outstream.Write(looppoint2);

            if (remaining_data != null)
                outstream.Write(remaining_data);

            //update section size
            var newsizeend = outstream.BaseStream.Position;
            outstream.BaseStream.Position = newsizestart;
            outstream.Write((uint) (newsizeend - (newsizestart + 4)));

            outstream.BaseStream.Position = newsizeend;
        }

        public override string ToString()
        {
            return "HIRC MusicSegment [ " +
                   "type: " + type + " " +
                   "length: " + length + " " +
                   "offset: " + offset + " " +
                   "id: " + id + " " +
                   "unknown1: " + unknown1.Length + " " +
                   "looppoint1: " + looppoint1 + " " +
                   "unknown2: " + unknown2.Length + " " +
                   "looppoint2: " + looppoint2 + " " +
                   "soundstructure: " + soundstructure + " " +
                   (remaining_data != null ? " REMAINING DATA! " + remaining_data.Length + " bytes" : "") +
                   "]";
        }
    }

    internal class HIRC
    {
        private readonly uint HIRC_tag = 0x43524948;
        public uint length;
        public List<object> objects = new List<object>();
        public uint objects_count;
        //public List<Tuple<HIRC_MusicTrack, HIRC_MusicSegment>>

        public long offset;
        public byte[] remaining_data = null;

        public HIRC(BinaryReader instream)
        {
            length = instream.ReadUInt32();
            offset = instream.BaseStream.Position;
            objects_count = instream.ReadUInt32();

            for (var x = 0; x < objects_count; x++)
            {
                var newobject = new object();

                var idbyte = instream.ReadByte();

                if (idbyte == 1)
                {
                    newobject = new HIRC_Settings(instream);
                }
                else if (idbyte == 2)
                {
                    newobject = new HIRC_SoundSFX(instream);
                }
                else if (idbyte == 3)
                {
                    newobject = new HIRC_EventAction(instream);
                }
                else if (idbyte == 10)
                {
                    newobject = new HIRC_MusicSegment(instream);
                }
                else if (idbyte == 11)
                {
                    newobject = new HIRC_MusicTrack(instream);
                }
                else
                {
                    newobject = new HIRC_object(instream);
                }
                objects.Add(newobject);
            }
        }

        public void StreamWrite(BinaryWriter outstream)
        {
            outstream.Write(HIRC_tag);
            var newsizestart = outstream.BaseStream.Position;
            outstream.Write(length);
            outstream.Write(objects_count);
            foreach (var hirc_obj in objects)
            {
                if (hirc_obj is HIRC_Settings)
                    (hirc_obj as HIRC_Settings).StreamWrite(outstream);
                else if (hirc_obj is HIRC_SoundSFX)
                    (hirc_obj as HIRC_SoundSFX).StreamWrite(outstream);
                else if (hirc_obj is HIRC_EventAction)
                    (hirc_obj as HIRC_EventAction).StreamWrite(outstream);
                else if (hirc_obj is HIRC_MusicTrack)
                    (hirc_obj as HIRC_MusicTrack).StreamWrite(outstream);
                else if (hirc_obj is HIRC_MusicSegment)
                    (hirc_obj as HIRC_MusicSegment).StreamWrite(outstream);
                else
                    (hirc_obj as HIRC_object).StreamWrite(outstream);
            }

            if (remaining_data != null)
                outstream.Write(remaining_data);

            //update section size
            var newsizeend = outstream.BaseStream.Position;
            outstream.BaseStream.Position = newsizestart;
            outstream.Write((uint) (newsizeend - (newsizestart + 4)));

            outstream.BaseStream.Position = newsizeend;
        }

        public override string ToString()
        {
            var ret_string = "[HIRC] offset: " + offset + " length: " + length + " objects_count: " + objects_count +
                             " objects.count: " + objects.Count +
                             (remaining_data != null ? " REMAINING DATA! " + remaining_data.Length + " bytes" : "");

            if (objects.Count > 0)
            {
                foreach (var hirc_obj in objects)
                {
                    ret_string += "\r\n\t" + hirc_obj;
                }
            }

            return ret_string;
        }
    }
}