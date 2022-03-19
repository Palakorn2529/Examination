package com.company;
import java.util.*;
public class Exam2_2 {

    public static void main(String[] args) {
        String[] dataSource = new String[5];
        Scanner sc = new Scanner(System.in);
        for(int item = 0;item<dataSource.length;item++){
            System.out.println("กรุณากรอกข้อมูลเข้าสู่ระบบ");
            String data = sc.nextLine();
            dataSource[item] = data;
        }
        String findStr = "";
        System.out.println("กรอกข้อมูลที่ท่านต้องการค้นหา");
        findStr = sc.nextLine();
        ArrayList<String>positions= new ArrayList<String>();
        for(int i = 0; i<dataSource.length;i++){
            String position = "";
            if(dataSource[i].contains(findStr)){
                position = String.valueOf(i+1);
                positions.add(position);
            }
        }
//        System.out.println(positions.size());
       String result = "";
       if(positions.size()!=0) {
           result = "พบอยู่ที่ตำแหน่ง ";
           for (int i = 0; i < positions.size(); i++) {

               result += positions.get(i)+",";
           }
           System.out.println(result.substring(0,result.length()-1));
       }
       else{
           result = "ไม่พบตำแหน่งที่ท่านค้นหา";
           System.out.println(result);
       }
    }
}
