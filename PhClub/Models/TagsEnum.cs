using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PhClub.Models
{
    public enum TagsEnum
    {
        [Display(Name = "Астрономия и космос")]
        Astronomy,
        [Display(Name = "Мир вокруг нас")]
        World,
        [Display(Name = "Фильмы, видео")]
        Movies,
        [Display(Name = "Новости")]
        News,
        [Display(Name = "Частное мнение")]
        Opinion,
        [Display(Name = "Здоровье")]
        Health,
        [Display(Name = "Достижения Науки")]
        Science,
        [Display(Name = "Это интересно!")]
        Interesting,
        [Display(Name = "История")]
        History,
        [Display(Name = "Проишествия")]
        Accidents,
        [Display(Name = "Удивительное рядом")]
        Amazing,
        [Display(Name = "Философия Синтеза")]
        Philosophy_of_Synthesis,
        [Display(Name = "Философские Чтения Синтеза")]
        FChS,
        [Display(Name = "Юмор")]
        Humour
    }
}