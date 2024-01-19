program oneandone;
var 
  a,b,s,p:real;
  begin
    try
  begin
    Writeln('Введите длину двух катетов');
    Readln(a, b);
    s:= Round((a * b) / 2);
    p:= Round((sqrt(sqr(a)+ sqr(b)) + a + b));
    writeln('Пощадь - ' + s +' Периметр - ' + p);
    end;
    except writeln('Введено неверно');
  end;
  end.