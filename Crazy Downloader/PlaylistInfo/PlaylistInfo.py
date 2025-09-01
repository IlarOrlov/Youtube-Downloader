import os
from pytube import Playlist
from winreg import *

def DownloadPlaylistVideos():
    global directory, format, link

    playlist = Playlist(link)

    #set amount of videos in playlist
    key = OpenKey(HKEY_CURRENT_USER, r"SOFTWARE\GPC", 0, KEY_WRITE)
    SetValueEx(key, "TotalVIdeos", 0, REG_SZ, f"{str(playlist.length)}")

    i = 0

    try:
        if format == "mp4":
            for video in playlist.videos:
                stream = video.streams.filter(file_extension="mp4").get_by_resolution("720p")
                stream.download(directory)

                i += 1
                SetValueEx(key, "DownloadedVideos", 0, REG_SZ, f"{str(i)}")

        if format == "mp3":
            for video in playlist.videos:
                stream = video.streams.filter(only_audio=True).first()
                out_file = stream.download(directory)

                base, ext = os.path.splitext(out_file)
                new_file = base + ".mp3"
                os.rename(out_file, new_file)

                i += 1
                SetValueEx(key, "DownloadedVideos", 0, REG_SZ, f"{str(i)}")

        if format == "video":
            return

    except Exception as ex:
        print("\nsomething went wrong..")
        print(f"\nException code:\n{ex}")

def GetRegistryValues():
    global directory, format, link

    aReg = ConnectRegistry(None, HKEY_CURRENT_USER)
    key = OpenKey(aReg, r"SOFTWARE\GPC")

    directory = QueryValueEx(key, "directory")[0]
    format = QueryValueEx(key, "format")[0]
    link = QueryValueEx(key, "link")[0]


#main
directory = r""
format = ""
link = ""

GetRegistryValues()

DownloadPlaylistVideos()